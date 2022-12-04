using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketSceneTransToPointRsp : BasePacket
    {
        public PacketSceneTransToPointRsp() : base(Enums.OpCode.SceneTransToPointRsp)
        {
            SceneTransToPointRsp proto = new SceneTransToPointRsp();

            Data = proto.ToByteArray();
        }
    }
}
