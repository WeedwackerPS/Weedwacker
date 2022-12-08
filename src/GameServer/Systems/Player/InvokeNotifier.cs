using Google.Protobuf;
using Weedwacker.GameServer.Packet;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class InvokeNotifier<T> where T : IBufferMessage
    {
        private readonly Player Owner;
        private readonly Type PacketType;

        List<T> ToScene = new();
        List<T> ToWorld = new();
        List<T> ToWorldOthers = new();
        List<T> ToHost = new();
        Dictionary<uint, T> ToPeer = new(); // peerId

        public InvokeNotifier(Player owner, Type packetType)
        {
            Owner = owner;
            if (packetType == typeof(PacketCombatInvocationsNotify) ||
                packetType == typeof(PacketAbilityInvocationsNotify) ||
                packetType == typeof(PacketClientAbilityInitFinishNotify))
            {
                PacketType = packetType;
            }
            else
                throw new Exception();
        }
        public void AddEntry(T entry, ForwardType forward, uint peer = default)
        {
            switch (forward)
            {
                case ForwardType.Local:
                    ToScene.Add(entry);
                    break;
                case ForwardType.ToAll:
                    ToWorld.Add(entry);
                    break;
                case ForwardType.ToAllExceptCur:
                    ToWorldOthers.Add(entry);
                    break;
                case ForwardType.ToHost:
                    ToHost.Add(entry);
                    break;
                case ForwardType.ToAllGuest: //???
                case ForwardType.ToPeer: //???
                case ForwardType.ToPeers:
                    ToScene.Add(entry);
                    break;
                case ForwardType.OnlyServer:
                    break;
                case ForwardType.ToAllExistExceptCur:
                    ToWorldOthers.Add(entry);
                    break;
            }
        }

        public async Task NotifyAsync()
        {
            while(Owner.World == null)
            {
                await Task.Yield();
            }
            if (ToScene.Any())
            {
                var packet = Activator.CreateInstance(PacketType, ToScene);
                await Owner.Scene.BroadcastPacketAsync((BasePacket)packet);
                ToScene.Clear();
            }
            if (ToWorld.Any())
            {
                var packet = Activator.CreateInstance(PacketType, ToWorld);
                await Owner.World.BroadcastPacketAsync((BasePacket)packet);
                ToWorld.Clear();
            }
            if (ToWorldOthers.Any())
            {
                var packet = Activator.CreateInstance(PacketType, ToWorldOthers);
                await Owner.World.BroadcastPacketToOthersAsync((BasePacket)packet, Owner);
                ToWorldOthers.Clear();
            }
            if (ToHost.Any())
            {
                var packet = Activator.CreateInstance(PacketType, ToHost);
                await Owner.World.Host.SendPacketAsync((BasePacket)packet);
                ToHost.Clear();
            }
        }
    }
}
