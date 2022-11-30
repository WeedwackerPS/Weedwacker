

using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.MarkMapReq)]
    internal class HandleMarkMapReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            MarkMapReq req = MarkMapReq.Parser.ParseFrom(payload);
            await session.Player.MapMarksManager.HandleMapMarkReq(req);
        }
    }
}
