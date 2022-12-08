using System.Numerics;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Ability;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    // should be abstract
    internal class BaseGadgetEntity : ScriptEntity
    {
        public override Vector3 Position { get => _Position; protected set => _Position = value; }
        public override Vector3 Rotation { get => _Rotation; protected set => _Rotation = value; }
        public GadgetData Data => GameData.GadgetDataMap[GadgetId];
        public int GadgetId { get; protected set; }

        public int DraftId { get; protected set; }
        protected BaseGadgetEntity(Scene? scene) : base(scene)
        {
            // USE ONLY FOR CLIENT GADGETS. WHO NEEDS MULTIPLE INHERITANCE ANYWAY?!
        }

        protected BaseGadgetEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
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
                MotionInfo = new MotionInfo() { Pos = new Shared.Network.Proto.Vector() { X = Position.X, Y = Position.Y, Z = Position.Z }, Rot = new Shared.Network.Proto.Vector() { X = Rotation.X, Y = Rotation.Y, Z = Rotation.Z }, Speed = new() },
                EntityClientData = new(),
                EntityAuthorityInfo = authority,
                LifeState = (uint)LifeState.LIFE_ALIVE
            };
            entityInfo.AnimatorParaList.Add(new AnimatorParameterValueInfoPair());

            PropPair pair = new PropPair()
            {
                Type = (uint)PlayerProperty.PROP_LEVEL,
                PropValue = new PropValue() { Type = (uint)PlayerProperty.PROP_LEVEL, Val = 1, Ival = 1 }
            };
            entityInfo.PropList.Add(pair);

            if (FightProps != null)
            {
                foreach (var entry in FightProps)
                {
                    FightPropPair fightProp = new FightPropPair() { PropType = (uint)entry.Key, PropValue = entry.Value };
                    entityInfo.FightPropList.Add(fightProp);
                }
            }

            SceneGadgetInfo gadgetInfo = new SceneGadgetInfo()
            {
                GadgetId = (uint)GadgetId,
                GroupId = GroupId,
                ConfigId = ConfigId,
                GadgetState = (uint)LiveState,
                IsEnableInteract = true,
                AuthorityPeerId = Scene.World.GetHostPeerId(),
                DraftId = (uint)DraftId
            };

            entityInfo.Gadget = gadgetInfo;

            return entityInfo;
        }
    }
}
