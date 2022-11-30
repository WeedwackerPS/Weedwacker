
using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketSceneTransToPointRsp : BasePacket
    {
        public PacketSceneTransToPointRsp(uint sceneId, uint pointId) : base(Enums.OpCode.SceneTransToPointRsp)
        {
            SceneTransToPointRsp p = new SceneTransToPointRsp()
            {
                SceneId = sceneId,
                PointId = pointId,
                Retcode = (int)Retcode.RetSucc
            };

            Data = p.ToByteArray();
        }
        public PacketSceneTransToPointRsp() : base(Enums.OpCode.SceneTransToPointRsp)
        {
            SceneTransToPointRsp p = new SceneTransToPointRsp();

            Data = p.ToByteArray();
        }
    }
}
