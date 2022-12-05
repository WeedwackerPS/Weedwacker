using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;
using static Weedwacker.Shared.Network.Proto.MarkMapReq.Types;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.MarkMapReq)]
    internal class HandleMarkMapReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            MarkMapReq req = MarkMapReq.Parser.ParseFrom(payload);
            Operation op = req.Op;
            switch (op)
            {
                case Operation.Add:
                    if (req.Mark.PointType == MapMarkPointType.FishPool)
                    {
                        await session.Player.MapMarksManager.Teleport(req);
                    }
                    break;
                case Operation.Mod:
                    //TODO:
                    break;
                case Operation.Del:
                    //TODO:
                    break;
            }
            await session.SendPacketAsync(new PacketMarkMapRsp(req.Mark));
        }
    }
}
