using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketUnlockTransPointRsp : BasePacket
    {
        public PacketUnlockTransPointRsp(Retcode retcode) : base(Enums.OpCode.UnlockTransPointRsp)
        {
            UnlockTransPointRsp p = new()
            {
                Retcode = (int)retcode,
            };

            Data = p.ToByteArray();
        }
    }
}
