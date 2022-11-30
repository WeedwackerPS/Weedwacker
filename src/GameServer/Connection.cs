using System.Buffers;
using System.Net;
using System.Reflection;
using Google.Protobuf.Reflection;
using KcpSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Enums;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer
{
    internal class Connection
    {
        public long? ConversationID => Conversation.ConversationId;
        readonly KcpConversation Conversation;
        readonly CancellationTokenSource CancelToken;
        public readonly IPEndPoint RemoteEndPoint;
        public SessionState State { get; set; } = SessionState.INACTIVE;
        public bool UseSecretKey { get; set; } = false;
        private byte[] SecretKey = new byte[0x1000];
        public Player? Player { get; set; }
        public uint ClientTime { get; private set; }
        public long LastPingTime { get; private set; }
        private uint LastClientSeq = 10;
        public static readonly List<OpCode> BANNED_PACKETS = new List<OpCode>() { OpCode.WindSeedClientNotify, OpCode.PlayerLuaShellNotify };
#if DEBUG
        private static uint LogIndex = 0;
#endif
        public Connection(KcpConversation conversation, IPEndPoint remote)
        {
            Conversation = conversation;
            RemoteEndPoint = remote;
            CancelToken = new CancellationTokenSource();
            Start();
        }
        async void Start()
        {
            Logger.WriteLine($"New connection to {RemoteEndPoint} created with conversation id {Conversation.ConversationId}");
            State = SessionState.WAITING_FOR_TOKEN;
            await ReceiveLoop();
        }
        public async void Stop()
        {
            if (Player != null)
            {
                await Player.OnLogoutAsync();
            }
            Listener.UnregisterConnection(this);
            Conversation.Dispose();
            try
            {
                CancelToken.Cancel();
                CancelToken.Dispose();
            }
            catch { }

        }

        public void UpdateLastPingTime(uint clientTime)
        {
            ClientTime = clientTime;
            LastPingTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

#if DEBUG
        public static void LogPacket(string sendOrRecv, ushort opcode, byte[] payload)
        {
            //Logger.DebugWriteLine($"{sendOrRecv}: {Enum.GetName(typeof(OpCode), opcode)}({opcode})\r\n{Convert.ToHexString(payload)}");
            var typ = AppDomain.CurrentDomain.GetAssemblies().
           SingleOrDefault(assembly => assembly.GetName().Name == "Shared").GetTypes().First(t => t.Name == $"{Enum.GetName(typeof(OpCode), opcode)}"); //get the type using the packet name
            var descriptor = (MessageDescriptor)typ.GetProperty("Descriptor", BindingFlags.Public | BindingFlags.Static).GetValue(null, null); // get the static property Descriptor
            var packet = descriptor.Parser.ParseFrom(payload);
            var formatter = Google.Protobuf.JsonFormatter.Default;
            var asJson = formatter.Format(packet);
            Logger.DebugWriteLine($"{sendOrRecv}: {Enum.GetName(typeof(OpCode), opcode)}({opcode})\r\n{asJson}");
            if (GameServer.Configuration.Server.KeepLog)
            {
                File.WriteAllText($"{GameServer.Configuration.Server.LogLocation}\\{LogIndex++}_Packet_{packet.GetType().Name}.json", JValue.Parse(asJson).ToString(Formatting.Indented));
            }
        }

        internal static void LogCombatInvocation(string sendOrRecv, CombatInvokeEntry entry, Type invocType)
        {
            var descriptor = (MessageDescriptor)invocType.GetProperty("Descriptor", BindingFlags.Public | BindingFlags.Static).GetValue(null, null); // get the static property Descriptor
            var invoc = descriptor.Parser.ParseFrom(entry.CombatData);
            var formatter = Google.Protobuf.JsonFormatter.Default;
            var asJson = formatter.Format(invoc);
            Logger.DebugWriteLine($"{sendOrRecv} {entry.ForwardType} | {entry.ArgumentType}: \r\n{asJson}");
            if (GameServer.Configuration.Server.KeepLog)
            {
                File.WriteAllText($"{GameServer.Configuration.Server.LogLocation}\\{LogIndex++}_CInv_{entry.ArgumentType}.json", JValue.Parse(asJson).ToString(Formatting.Indented));
            }
        }

        internal static void LogAbilityInvocation(string sendOrRecv, AbilityInvokeEntry entry, Type invocType, uint entityId)
        {
            var descriptor = (MessageDescriptor)invocType.GetProperty("Descriptor", BindingFlags.Public | BindingFlags.Static).GetValue(null, null); // get the static property Descriptor
            var invoc = descriptor.Parser.ParseFrom(entry.AbilityData);
            var formatter = Google.Protobuf.JsonFormatter.Default;
            var asJson = formatter.Format(invoc);
            var headJson = formatter.Format(entry.Head);
            Logger.DebugWriteLine($"{sendOrRecv} {entry.Head} | {entry.ForwardType} | {entry.ArgumentType}: \r\n{asJson}");
            if (GameServer.Configuration.Server.KeepLog)
            {
                File.WriteAllText($"{GameServer.Configuration.Server.LogLocation}\\{LogIndex++}_AInv_Head_{entityId}_{entry.ArgumentType}.json", JValue.Parse(headJson).ToString(Formatting.Indented));
                File.WriteAllText($"{GameServer.Configuration.Server.LogLocation}\\{LogIndex++}_AInv_{entityId}_{entry.ArgumentType}.json", JValue.Parse(asJson).ToString(Formatting.Indented));
            }
        }
#endif
        async Task ReceiveLoop()
        {
            while (!CancelToken.IsCancellationRequested)
            {
                // WaitToReceiveAsync call completes when there is at least one message is received or the transport is closed.
                KcpConversationReceiveResult result = await Conversation.WaitToReceiveAsync(CancelToken.Token);
                if (result.TransportClosed)
                {
                    Logger.DebugWriteLine("Connection was closed");
                    break;
                }
                if (result.BytesReceived > Listener.MAX_MSG_SIZE)
                {
                    // The message is too large.
                    Logger.WriteErrorLine("Packet too large");
                    Conversation.SetTransportClosed();
                    break;
                }

                byte[] buffer = ArrayPool<byte>.Shared.Rent(result.BytesReceived);
                try
                {
                    // TryReceive should not return false here, unless the transport is closed.
                    // So we don't need to check for result.TransportClosed.
                    if (!Conversation.TryReceive(buffer, out result))
                    {
                        Logger.WriteErrorLine("Failed to receive packet");
                        break;
                    }
                    await ProcessMessageAsync(buffer.AsMemory(0, result.BytesReceived));
                }
                catch (Exception ex)
                {
                    Logger.WriteErrorLine("Packet parse error", ex);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
            Stop();
        }

        // DO THE PROCESSING OF THE GAME PACKET
        async Task ProcessMessageAsync(Memory<byte> data)
        {
            byte[] gamePacket = data.ToArray();
            // Decrypt and turn back into a packet
            Crypto.Xor(gamePacket, UseSecretKey ? SecretKey : Crypto.DISPATCH_KEY);
            await using var ms = new MemoryStream(gamePacket);
            using var br = new BinaryReader(ms);
            // Log
            //logPacket(packet);
            // Handle
            try
            {
#if DEBUG
                bool allDebug = GameServer.Configuration.Server.LogPackets == Shared.Enums.ServerDebugMode.ALL;
#endif
                while (br.BaseStream.Position < br.BaseStream.Length)
                {
                    // Length
                    if (br.BaseStream.Length - br.BaseStream.Position < 12)
                    {
                        return;
                    }
                    // Packet sanity check
                    ushort Magic1 = br.ReadUInt16BE();
                    if (Magic1 != 0x4567)
                    {
#if DEBUG
                        if (allDebug)
                        {
                            Logger.WriteErrorLine($"Bad Data Package Received: got 0x{Magic1:X} ,expect 0x4567");
                        }
#endif
                        return; // Bad packet
                    }
                    // Data
                    ushort opcode = br.ReadUInt16BE();
                    ushort headerLength = br.ReadUInt16BE();
                    uint payloadLength = br.ReadUInt32BE();
                    byte[] header = br.ReadBytes(headerLength);
                    byte[] payload = br.ReadBytes((int)payloadLength);

                    // Sanity check #2
                    ushort Magic2 = br.ReadUInt16BE();
                    if (Magic2 != 0x89ab)
                    {
#if DEBUG
                        if (allDebug)
                        {
                            Logger.WriteErrorLine($"Bad Data Package Received: got {Magic2} ,expect 0x89ab");
                        }
#endif
                        return; // Bad packet
                    }
#if DEBUG
                    // Log packet
                    ServerDebugMode debugMode = GameServer.Configuration.Server.LogPackets;
                    if (debugMode == ServerDebugMode.ALL)
                    {
                        goto Log;
                    }
                    else if (debugMode == ServerDebugMode.WHITELIST && GameServer.Configuration.Server.DebugWhitelist.Contains((OpCode)opcode))
                    {
                        goto Log;
                    }
                    else if (debugMode == ServerDebugMode.BLACKLIST && !GameServer.Configuration.Server.DebugBlacklist.Contains((OpCode)opcode))
                    {
                        goto Log;
                    }
                    else
                        goto NotLog;
                    Log:
                    LogPacket("RECV", opcode, payload);
                NotLog:
#endif
                    bool handled = await HandlePacketAsync(opcode, header, payload);

#if DEBUG
                    // Log unhandled packets
                    if (!handled && debugMode == ServerDebugMode.MISSING)
                    {
                        Logger.DebugWriteWarningLine($"Unhandled packet ({opcode}): {Enum.GetName(typeof(OpCode), opcode)}");
                    }
#endif
                }

            }
            catch (Exception e)
            {
                Logger.WriteErrorLine(e.Message, e);
            }
            finally
            {
                await ms.DisposeAsync();
            }
        }

        public async Task<bool> HandlePacketAsync(ushort opcode, byte[] header, byte[] payload)
        {
            // Find the Handler for this opcode
            var query =
                from type in Assembly.GetExecutingAssembly().GetTypes()
                where type.GetCustomAttribute<OpCodeAttribute>()?.OpCodeNum == opcode
                select type;
            var handlerType = query.FirstOrDefault();
            if (handlerType != null)
            {
                // Handle
                var handler = (BaseHandler)Activator.CreateInstance(handlerType);
                // Make sure session is ready for packets
                SessionState state = State;
                switch ((OpCode)opcode)
                {
                    case OpCode.GetPlayerTokenReq:
                        {
                            if (state != SessionState.WAITING_FOR_TOKEN)
                            {
                                return true;
                            }
                            goto default;
                        }
                    case OpCode.PlayerLoginReq:
                        {
                            if (state != SessionState.WAITING_FOR_LOGIN)
                            {
                                return true;
                            }
                            goto default;
                        }
                    case OpCode.SetPlayerBornDataReq:
                        {
                            if (state != SessionState.PICKING_CHARACTER)
                            {
                                return true;
                            }
                            goto default;
                        }
                    default:
                        break;
                }
                await handler.HandleAsync(this, header, payload);
                return true;
            }
            else
            {
                Logger.DebugWriteWarningLine($"Unhandled packet: {Enum.GetName(typeof(OpCode), opcode)}");
                return false;
            }
        }


        public async Task SendPacketAsync(BasePacket packet)
        {
            // Test
            if (packet.Opcode <= 0)
            {
                Logger.DebugWriteLine("Tried to send packet with missing cmd id!");
                return;
            }

            // DO NOT REMOVE (unless we find a way to validate code before sending to client which I don't think we can)
            // Stop WindSeedClientNotify from being sent for security purposes.
            if (BANNED_PACKETS.Contains((OpCode)packet.Opcode))
            {
                return;
            }

            // Header
            if (packet.ShouldBuildHeader)
            {
                packet.BuildHeader(++LastClientSeq);
            }
#if DEBUG
            // Log
            switch (GameServer.Configuration.Server.LogPackets)
            {
                case Shared.Enums.ServerDebugMode.ALL:
                    {
                        LogPacket("SEND", packet.Opcode, packet.Data);
                        break;
                    }
                case Shared.Enums.ServerDebugMode.WHITELIST:
                    {
                        if (GameServer.Configuration.Server.DebugWhitelist.Contains((OpCode)packet.Opcode))
                        {
                            LogPacket("SEND", packet.Opcode, packet.Data);
                        }
                        break;
                    }
                case Shared.Enums.ServerDebugMode.BLACKLIST:
                    {
                        if (!GameServer.Configuration.Server.DebugBlacklist.Contains((OpCode)packet.Opcode))
                        {
                            LogPacket("SEND", packet.Opcode, packet.Data);
                        }
                        break;
                    }
            }
#endif
            byte[] packetBytes = await packet.BuildPacketAsync();

            Crypto.Xor(packetBytes, UseSecretKey ? SecretKey : Crypto.DISPATCH_KEY);

            await Conversation.SendAsync(packetBytes, CancelToken.Token);
        }

        public async Task SetSecretKey(ulong seed)
        {
            var mt = new Crypto.MT19937(seed);
            mt.Seed(mt.Int63());
            mt.Int63();

            await using var ms = new MemoryStream(0x1000);
            using var bw = new BinaryWriter(ms);
            for (int i = 0; i < 0x1000; i += 8)
            {
                bw.WriteUInt64BE(mt.Int63());
            }

            SecretKey = ms.ToArray();
        }
    }
}
