using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Ability;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    // should be abstract
    internal abstract class BaseGadgetEntity : SceneEntity
    {
        public GadgetData Data => GameData.GadgetDataMap[GadgetId];
        public int GadgetId { get; protected set; }

        public int DraftId { get; protected set; }
        protected BaseGadgetEntity(Scene? scene) : base(scene)
        {
        }

        // hacky
        public BaseGadgetEntity(Scene scene, int gadgetId) : base(scene)
        {
            GadgetId = gadgetId;
            EntityId = scene.World.GetNextEntityId(EntityIdType.GADGET);
            AbilityManager = new GadgetAbilityManager(this);
        }

        public override SceneEntityInfo ToProto()
        {
            EntityAuthorityInfo authority = new EntityAuthorityInfo()
            {
                AbilityInfo = new AbilitySyncStateInfo(),
                RendererChangedInfo = new EntityRendererChangedInfo(),
                AiInfo = new SceneEntityAiInfo() { IsAiOpen = true, BornPos = new() },
                BornPos = new()
            };

            SceneEntityInfo entityInfo = new SceneEntityInfo()
            {
                EntityId = EntityId,
                EntityType = ProtEntityType.Gadget,
                MotionInfo = MotionInfo,
                EntityClientData = new(),
                EntityAuthorityInfo = authority,
                LifeState = (uint)LifeState.LIFE_ALIVE
            };
            entityInfo.AnimatorParaList.Add(new AnimatorParameterValueInfoPair());

            PropPair pair = new()
            {
                Type = (uint)PlayerProperty.PROP_LEVEL,
                PropValue = new PropValue() { Type = (uint)PlayerProperty.PROP_LEVEL, Val = 1, Ival = 1 }
            };
            entityInfo.PropList.Add(pair);

            if (FightProps != null)
            {
                foreach (var entry in FightProps)
                {
                    FightPropPair fightProp = new() { PropType = (uint)entry.Key, PropValue = entry.Value };
                    entityInfo.FightPropList.Add(fightProp);
                }
            }

            SceneGadgetInfo gadgetInfo = new()
            {
                GadgetId = (uint)GadgetId,
                GadgetState = (uint)LiveState,
                IsEnableInteract = true,
                AuthorityPeerId = Scene.World.HostPeerId,
                DraftId = (uint)DraftId,
            };

            entityInfo.Gadget = gadgetInfo;

            return entityInfo;
        }
    }
}
