using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketWorldPlayerLocationNotify : BasePacket
    {
        public PacketWorldPlayerLocationNotify(World world) : base(Enums.OpCode.WorldPlayerLocationNotify)
        {
            WorldPlayerLocationNotify proto = new WorldPlayerLocationNotify();

            foreach (Player p in world.Players)
            {
                proto.PlayerWorldLocList.Add(new PlayerWorldLocationInfo() { SceneId = (uint)p.SceneId, PlayerLoc = p.PlayerLocationInfo });
            }

            Data = proto.ToByteArray();
        }
    }
}
