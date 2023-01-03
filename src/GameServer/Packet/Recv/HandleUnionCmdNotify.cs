using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.UnionCmdNotify)]
    internal class HandleUnionCmdNotify : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            UnionCmdNotify req = UnionCmdNotify.Parser.ParseFrom(payload);
            foreach (UnionCmd cmd in req.CmdList)
            {
                ushort cmdOpcode = (ushort)cmd.MessageId;
                byte[] cmdPayload = cmd.Body.ToByteArray();
#if DEBUG
                ServerDebugMode debugMode = GameServer.Configuration.Server.LogPackets;
                if (debugMode == ServerDebugMode.ALL)
                {
                    goto Log;
                }
                else if (debugMode == ServerDebugMode.WHITELIST && GameServer.Configuration.Server.DebugWhitelist.Contains((OpCode)cmd.MessageId))
                {
                    goto Log;
                }
                else if (debugMode == ServerDebugMode.BLACKLIST && !GameServer.Configuration.Server.DebugBlacklist.Contains((OpCode)cmd.MessageId))
                {
                    goto Log;
                }
                else
                    goto NotLog;
                Log:
                Connection.LogPacket("RECV in Union", cmdOpcode, cmdPayload);
            NotLog:
#endif
                // Handle the subPacket
                await session.HandlePacketAsync(cmdOpcode, EMPTY_BYTE_ARRAY, cmd.Body.ToByteArray());
            }

            // Notify Peers
            await session.Player.AbilityInvNotifyList.NotifyAsync();
            await session.Player.CombatInvNotifyList.NotifyAsync();
            await session.Player.ClientAbilityInitFinishNotifyList.NotifyAsync();
        }
    }
}
