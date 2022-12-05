using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketSceneTransToPointRsp : BasePacket
    {
        public PacketSceneTransToPointRsp(Retcode ret, uint sceneId, uint pointId) : base(Enums.OpCode.SceneTransToPointRsp)
        {
            SceneTransToPointRsp p = new SceneTransToPointRsp()
            {
                SceneId = sceneId,
                PointId = pointId,
                Retcode = (int)ret,
            };
            Data = p.ToByteArray();
        }
    }
}
