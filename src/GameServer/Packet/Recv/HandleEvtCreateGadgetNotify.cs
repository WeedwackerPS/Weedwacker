using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.EvtCreateGadgetNotify)]
    internal class HandleEvtCreateGadgetNotify : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            EvtCreateGadgetNotify req = EvtCreateGadgetNotify.Parser.ParseFrom(payload);

            // Sanity check - dont add duplicate entities
            if (session.Player.Scene.GetEntityById(req.EntityId) != null)
            {
                return;
            }

            // Create entity and summon in world
            ClientGadgetEntity gadget = new ClientGadgetEntity(session.Player.Scene, session.Player, req);

            await session.Player.Scene.OnPlayerCreateGadget(gadget);
        }
    }
}
