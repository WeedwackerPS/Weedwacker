using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.EvtDestroyGadgetNotify)]
    internal class HandleEvtDestroyGadgetNotify : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            EvtDestroyGadgetNotify req = EvtDestroyGadgetNotify.Parser.ParseFrom(payload);

            await session.Player.Scene.OnPlayerDestroyGadget(req.EntityId);
        }
    }
}
