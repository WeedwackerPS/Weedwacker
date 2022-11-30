

using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketScenePointUnlockNotify : BasePacket
    {
        public PacketScenePointUnlockNotify(uint sceneId,uint pointId) : base(Enums.OpCode.ScenePointUnlockNotify)
        {
            ScenePointUnlockNotify p = new ScenePointUnlockNotify()
            {
                SceneId = sceneId,
            };
            p.PointList.Add(pointId);
            Data = p.ToByteArray();
        }

    }
}
