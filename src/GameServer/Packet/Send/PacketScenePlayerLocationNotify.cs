using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketScenePlayerLocationNotify : BasePacket
    {
        public PacketScenePlayerLocationNotify(Scene scene) : base(Enums.OpCode.ScenePlayerLocationNotify)
        {
            ScenePlayerLocationNotify proto = new ScenePlayerLocationNotify()
            {
                SceneId = (uint)scene.SceneId,
                //VehicleLocList = , //TODO
            };

            foreach (Player p in scene.Players)
            {
                proto.PlayerLocList.Add(p.GetPlayerLocationInfo());
            }

            Data = proto.ToByteArray();
        }
    }
}
