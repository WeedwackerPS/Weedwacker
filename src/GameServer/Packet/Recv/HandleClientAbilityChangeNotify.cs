using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.ClientAbilityChangeNotify)]
    internal class HandleClientAbilityChangeNotify : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            ClientAbilityChangeNotify p = ClientAbilityChangeNotify.Parser.ParseFrom(payload);
            if (session.Player.Scene.Entities.TryGetValue(p.EntityId, out BaseEntity? entity))
            {
                foreach (var invoke in p.Invokes)
                {
                    await entity.AbilityManager.HandleAbilityInvokeAsync(invoke);
                }
            }
            else if (session.Player.Scene.ScriptEntities.TryGetValue(p.EntityId, out ScriptEntity? scriptEntities))
            {
                foreach (var invoke in p.Invokes)
                {
                    await scriptEntities.AbilityManager.HandleAbilityInvokeAsync(invoke);
                }
            }
            else
            {
                entity = session.Player.TeamManager.ActiveTeam.Values.Where(w => w.EntityId == p.EntityId).FirstOrDefault();
                if (entity != null)
                {
                    foreach (var invoke in p.Invokes)
                    {
                        await entity.AbilityManager.HandleAbilityInvokeAsync(invoke);
                    }
                }
                else
                    Logger.DebugWriteLine($"Failed to find entity {p.EntityId}");
            }
        }
    }
}
