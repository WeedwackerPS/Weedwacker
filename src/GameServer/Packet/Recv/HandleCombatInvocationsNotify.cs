using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.CombatInvocationsNotify)]
    internal class HandleCombatInvocationsNotify : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            CombatInvocationsNotify p = CombatInvocationsNotify.Parser.ParseFrom(payload);
            foreach (CombatInvokeEntry entry in p.InvokeList)
            {
                IBufferMessage info;
                ByteString data = entry.CombatData;
                switch (entry.ArgumentType)
                {
                    case CombatTypeArgument.None:
                        goto default;
                        break;
                    case CombatTypeArgument.EvtBeingHit:
                        info = EvtBeingHitInfo.Parser.ParseFrom(data);
                        var hitInfo = info as EvtBeingHitInfo;

                        if (hitInfo != null)
                        {
                            HandleEvtBeingHit(session, hitInfo);
                        }

                        break;

                    case CombatTypeArgument.AnimatorStateChanged:
                        info = EvtAnimatorStateChangedInfo.Parser.ParseFrom(data);
                        //TODO
                        break;
                    case CombatTypeArgument.FaceToDir:
                        info = EvtFaceToDirInfo.Parser.ParseFrom(data);
                        //TODO
                        break;
                    case CombatTypeArgument.SetAttackTarget:
                        info = EvtSetAttackTargetInfo.Parser.ParseFrom(data);
                        //TODO
                        break;
                    case CombatTypeArgument.RushMove:
                        info = EvtRushMoveInfo.Parser.ParseFrom(data);
                        //TODO
                        break;
                    case CombatTypeArgument.AnimatorParameterChanged:
                        info = EvtAnimatorParameterInfo.Parser.ParseFrom(data);
                        //TODO
                        break;
                    case CombatTypeArgument.EntityMove: // Seems to only handle avatar entities, despite the generic name...
                        info = EntityMoveInfo.Parser.ParseFrom(data);
                        var moveInfo = info as EntityMoveInfo;
                        if (session.Player.TeamManager.GetCurrentAvatarEntity().EntityId == moveInfo.EntityId)
                        {
                            var avatar = session.Player.TeamManager.GetCurrentAvatarEntity();
                            await avatar.MoveAsync(moveInfo);
                        }
                        break;
                    case CombatTypeArgument.SyncEntityPosition:
                        info = EvtSyncEntityPositionInfo.Parser.ParseFrom(data);
                        //TODO
                        break;
                    case CombatTypeArgument.SteerMotionInfo:
                        info = EvtCombatSteerMotionInfo.Parser.ParseFrom(data);
                        //TODO
                        break;
                    case CombatTypeArgument.ForceSetPosInfo:
                        info = EvtCombatForceSetPosInfo.Parser.ParseFrom(data);
                        //TODO
                        break;
                    case CombatTypeArgument.CompensatePosDiff:
                        info = EvtCompensatePosDiffInfo.Parser.ParseFrom(data);
                        //TODO
                        break;
                    case CombatTypeArgument.MonsterDoBlink:
                        info = EvtMonsterDoBlink.Parser.ParseFrom(data);
                        //TODO
                        break;
                    case CombatTypeArgument.FixedRushMove:
                        info = EvtFixedRushMove.Parser.ParseFrom(data);
                        //TODO
                        break;
                    case CombatTypeArgument.SyncTransform:
                        info = EvtSyncTransform.Parser.ParseFrom(data);
                        //TODO
                        break;
                    case CombatTypeArgument.LightCoreMove:
                        info = EvtLightCoreMove.Parser.ParseFrom(data);
                        //TODO
                        break;
                    case CombatTypeArgument.BeingHealedNtf:
                        //TODO
                        info = EvtBeingHealedNotify.Parser.ParseFrom(data);
                        break;
                    case CombatTypeArgument.GrapplingHookMove:
                        //TODO
                        info = EvtGrapplingHookMove.Parser.ParseFrom(data);
                        break;
                    case CombatTypeArgument.SkillAnchorPositionNtf:
                        //TODO
                        info = EvtSyncSkillAnchorPosition.Parser.ParseFrom(data);
                        break;
                    default:
                        info = new EntityMoveInfo();
                        break;
                }

                session.Player.CombatInvNotifyList.AddEntry(entry, entry.ForwardType);
#if DEBUG
                if (GameServer.Configuration.Server.LogCombatInvocations)
                {
                    if (!GameServer.Configuration.Server.CombatArgTypeBlacklist.Contains(entry.ArgumentType))
                    {
                        Connection.LogCombatInvocation("RECV combat invoke: ", entry, info.GetType());
                    }
                }
#endif
            }
        }

        private async Task HandleEvtBeingHit(Connection session, EvtBeingHitInfo hitInfo)
        {
            await session.Player.Scene.HandleAttackAsync(hitInfo.AttackResult);
        }
    }
}
