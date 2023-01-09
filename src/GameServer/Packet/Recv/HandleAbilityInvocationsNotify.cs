using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.AbilityInvocationsNotify)]
    internal class HandleAbilityInvocationsNotify : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            AbilityInvocationsNotify proto = AbilityInvocationsNotify.Parser.ParseFrom(payload);
            foreach (var invoke in proto.Invokes)
            {
                if (session.Player.Scene.ScriptEntities.TryGetValue(invoke.EntityId, out IScriptEntity? scriptEntity) && (scriptEntity as SceneEntity).AbilityManager != null)
                    await (scriptEntity as SceneEntity).AbilityManager.HandleAbilityInvokeAsync(invoke);

                else if (session.Player.Scene.Entities.TryGetValue(invoke.EntityId, out BaseEntity? entity) && entity.AbilityManager != null)
                    await entity.AbilityManager.HandleAbilityInvokeAsync(invoke);

                else if (invoke.EntityId == session.Player.World.LevelEntityId)
                    await session.Player.World.AbilityManager.HandleAbilityInvokeAsync(invoke);

                else if (invoke.EntityId == session.Player.World.LevelEntityId)
                    await session.Player.World.AbilityManager.HandleAbilityInvokeAsync(invoke);
                else
                {
                    Logger.DebugWriteLine($"Failed to find entity {invoke.EntityId}");
                    break;
                }

                session.Player.AbilityInvNotifyList.AddEntry(invoke, invoke.ForwardType, invoke.ForwardPeer);

            }
        }
    }
}
