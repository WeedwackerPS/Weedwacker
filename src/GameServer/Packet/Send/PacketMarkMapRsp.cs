using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketMarkMapRsp : BasePacket
    {
        public PacketMarkMapRsp(MapMarkPoint mapMarkPoint) : base(Enums.OpCode.MarkMapRsp)
        {
            MarkMapRsp p = new MarkMapRsp()
            {
                Retcode = (int)Retcode.RetSucc,
            };
            p.MarkList.Add(mapMarkPoint);
            Data = p.ToByteArray();
        }
    }
}
