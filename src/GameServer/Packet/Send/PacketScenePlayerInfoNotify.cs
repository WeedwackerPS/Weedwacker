using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketScenePlayerInfoNotify : BasePacket
    {
        public PacketScenePlayerInfoNotify(World world) : base(Enums.OpCode.ScenePlayerInfoNotify)
        {
            ScenePlayerInfoNotify proto = new ScenePlayerInfoNotify();

            foreach (Player p in world.Players)
            {
                ScenePlayerInfo pInfo = new ScenePlayerInfo()
                {
                    Uid = (uint)p.GameUid,
                    PeerId = p.PeerId,
                    Name = p.NickName,
                    SceneId = (uint)p.SceneId,
                    OnlinePlayerInfo = p.GetOnlinePlayerInfo()
                };

                proto.PlayerInfoList.Add(pInfo);
            }

            Data = proto.ToByteArray();
        }
    }
}
