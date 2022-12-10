using System.Numerics;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Ability;
using Weedwacker.GameServer.Systems.Script;
using Weedwacker.GameServer.Systems.Script.Scene;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class MonsterEntity : ScriptEntity
    {
        public readonly MonsterData MonsterData;
        public readonly SceneGroup.SpawnInfo? SpawnInfo;
        public readonly int Level;
        public readonly uint RightWeaponEntityId;
        public readonly uint LeftWeaponEntityId;
        public int PoseId;

        public static Task<MonsterEntity> CreateAsync(Scene scene, MonsterData monsterData, int level, SceneGroup.Monster spawnInfo, uint blockId, uint groupId)
        {
            MonsterEntity ret = new MonsterEntity(scene, monsterData, level, spawnInfo, blockId, groupId);
            return ret.InitializeAsync();
        }

        public static Task<MonsterEntity> CreateAsync(Scene scene, Player.Player targetPlayer, MonsterData monsterData, int level, Vector3 pos = default, Vector3 rot = default)
        {
            var ret = new MonsterEntity(scene, targetPlayer, monsterData, level, pos, rot);
            return ret.InitializeAsync();
        }

        private async Task<MonsterEntity> InitializeAsync()
        {
            AbilityManager = new MonsterAbilityManager(this);
            await RecalcStatsAsync();
            return this;
        }
        private MonsterEntity(Scene scene, MonsterData monsterData, int level, SceneGroup.Monster? spawnInfo, uint blockId, uint groupId) : base(scene, blockId, groupId, spawnInfo.config_id)
        {

            EntityId = scene.World.GetNextEntityId(EntityIdType.MONSTER);
            MonsterData = monsterData;
            FightProps = new();
            Position = spawnInfo.pos;
            Rotation = spawnInfo.rot;
            SpawnInfo = spawnInfo;
            Level = level;

            // Monster weapon
            if (monsterData.equips[0] != 0) RightWeaponEntityId = scene.World.GetNextEntityId(EntityIdType.WEAPON);
            if (monsterData.equips[1] != 0) LeftWeaponEntityId = scene.World.GetNextEntityId(EntityIdType.WEAPON);
        }

        private MonsterEntity(Scene? scene, Player.Player targetPlayer, MonsterData monsterData, int level, Vector3 posOffset = default, Vector3 rotOffset = default) : base(scene)
        {
            EntityId = scene.World.GetNextEntityId(EntityIdType.MONSTER);
            MonsterData = monsterData;
            FightProps = new();
            Level = level;
            Position = targetPlayer.Position + new Vector3(10, 0, 10) + posOffset;
            Rotation = targetPlayer.Rotation + rotOffset;

            // Monster weapon
            if (monsterData.equips[0] != 0) RightWeaponEntityId = scene.World.GetNextEntityId(EntityIdType.WEAPON);
            if (monsterData.equips[1] != 0) LeftWeaponEntityId = scene.World.GetNextEntityId(EntityIdType.WEAPON);
        }

        public override async Task OnInteractAsync(Player.Player player, GadgetInteractReq interactReq)
        {
            EnvAnimalGatherData gatherData = GameData.EnvAnimalGatherDataMap[MonsterData.id];

            if (gatherData == null)
            {
                return;
            }
            List<Tuple<int, int>> items = new();
            gatherData.gatherItemId.AsParallel().ForAll(w => items.Add(Tuple.Create(w.id, w.count)));
            await player.Inventory.AddItemByIdManyAsync(items, ActionReason.SubfieldDrop);

            await Scene.KillEntityAsync(this);
        }


        public override async Task OnCreateAsync()
        {
            if (SpawnInfo != null)
            {
                // Lua event
                //await Scene.ScriptManager.CallEvent(EventType.EVENT_ANY_MONSTER_LIVE, new ScriptArgs((int)ConfigId));
            }
        }

        public override async Task DamageAsync(float amount, uint killerId)
        {
            // Get HP before damage.
            float hpBeforeDamage = FightProps[FightProperty.FIGHT_PROP_CUR_HP];

            // Apply damage.
            await base.DamageAsync(amount, killerId);

            // Get HP after damage.
            float hpAfterDamage = FightProps[FightProperty.FIGHT_PROP_CUR_HP];

            // Invoke energy drop logic.
            foreach (Player.Player player in Scene.Players)
            {
                player.EnergyManager.HandleMonsterEnergyDrop(this, hpBeforeDamage, hpAfterDamage);
            }
        }


        public override async Task OnDeathAsync(uint killerId)
        {
            await base.OnDeathAsync(killerId); // Invoke base class's onDeath() method.


            Scene.DeadSpawnedEntities.Add(SpawnInfo);

            //TODO challenge

            if (GroupId > 0)
            {
                if (Scene.ScriptManager.ScriptMonsterSpawnService != null)
                {
                    Scene.ScriptManager.ScriptMonsterSpawnService.OnMonsterDead(this);
                }
            }
            // Battle Pass trigger
            Scene.Players.ForEach(p => p.BattlePassManager.TriggerMission(WatcherTriggerType.TRIGGER_MONSTER_DIE, MonsterData.id, 1));
        }

        public async Task RecalcStatsAsync()
        {
            await Task.Yield();
            // Get hp percent, set to 100% if none
            float hpPercent = FightProps.GetValueOrDefault(FightProperty.FIGHT_PROP_MAX_HP, 0) <= 0 ? 1f : FightProps.GetValueOrDefault(FightProperty.FIGHT_PROP_CUR_HP) / FightProps.GetValueOrDefault(FightProperty.FIGHT_PROP_MAX_HP, MonsterData.hpBase);

            // Base stats
            FightProps[FightProperty.FIGHT_PROP_BASE_HP] = MonsterData.hpBase;
            FightProps[FightProperty.FIGHT_PROP_BASE_ATTACK] = MonsterData.attackBase;
            FightProps[FightProperty.FIGHT_PROP_BASE_DEFENSE] = MonsterData.defenseBase;

            FightProps[FightProperty.FIGHT_PROP_PHYSICAL_SUB_HURT] = MonsterData.physicalSubHurt;
            FightProps[FightProperty.FIGHT_PROP_FIRE_SUB_HURT] = MonsterData.fireSubHurt;
            FightProps[FightProperty.FIGHT_PROP_ELEC_SUB_HURT] = MonsterData.elecSubHurt;
            FightProps[FightProperty.FIGHT_PROP_WATER_SUB_HURT] = MonsterData.waterSubHurt;
            FightProps[FightProperty.FIGHT_PROP_GRASS_SUB_HURT] = MonsterData.grassSubHurt;
            FightProps[FightProperty.FIGHT_PROP_WIND_SUB_HURT] = MonsterData.windSubHurt;
            FightProps[FightProperty.FIGHT_PROP_ROCK_SUB_HURT] = MonsterData.rockSubHurt;
            FightProps[FightProperty.FIGHT_PROP_ICE_SUB_HURT] = MonsterData.iceSubHurt;

            // Level curve
            MonsterCurveData curve = GameData.MonsterCurveDataMap[Level];
            if (curve != null)
            {
                foreach (PropGrowCurve growCurve in MonsterData.propGrowCurves)
                {
                    FightProperty prop = growCurve.type;
                    FightProps[prop] = MonsterCurveData.CalcValue(FightProps[prop], curve.GetArith(growCurve.growCurve));
                }
            }

            // Set % stats
            FightProps[FightProperty.FIGHT_PROP_MAX_HP] =
                (FightProps[FightProperty.FIGHT_PROP_BASE_HP] * (1f + FightProps.GetValueOrDefault(FightProperty.FIGHT_PROP_HP_PERCENT))) + FightProps.GetValueOrDefault(FightProperty.FIGHT_PROP_HP);
            FightProps[FightProperty.FIGHT_PROP_CUR_ATTACK] =
                (FightProps[FightProperty.FIGHT_PROP_BASE_ATTACK] * (1f + FightProps.GetValueOrDefault(FightProperty.FIGHT_PROP_ATTACK_PERCENT))) + FightProps.GetValueOrDefault(FightProperty.FIGHT_PROP_ATTACK);
            FightProps[FightProperty.FIGHT_PROP_CUR_DEFENSE] =
                (FightProps[FightProperty.FIGHT_PROP_BASE_DEFENSE] * (1f + FightProps.GetValueOrDefault(FightProperty.FIGHT_PROP_DEFENSE_PERCENT))) + FightProps.GetValueOrDefault(FightProperty.FIGHT_PROP_DEFENSE);

            // Set current hp
            FightProps[FightProperty.FIGHT_PROP_CUR_HP] = FightProps[FightProperty.FIGHT_PROP_MAX_HP] * hpPercent;
        }

        public override SceneEntityInfo ToProto()
        {
            //TODO
            EntityAuthorityInfo authority = new EntityAuthorityInfo()
            {
                AbilityInfo = new(),
                RendererChangedInfo = new(),
                AiInfo = new() { IsAiOpen = true, BornPos = new Shared.Network.Proto.Vector() { X = Position.X, Y = Position.Y, Z = Position.Z } },
                BornPos = SpawnInfo != null ? new Shared.Network.Proto.Vector() { X = SpawnInfo.pos.X, Y = SpawnInfo.pos.Y, Z = SpawnInfo.pos.Z } : new Shared.Network.Proto.Vector() { X = Position.X, Y = Position.Y, Z = Position.Z },
            };

            SceneEntityInfo entityInfo = new()
            {
                EntityId = EntityId,
                EntityType = ProtEntityType.Monster,
                MotionInfo = GetMotionInfo(),
                EntityClientData = new(),
                EntityAuthorityInfo = authority,
                LifeState = (uint)LiveState,
            };
            entityInfo.AnimatorParaList.Add(new AnimatorParameterValueInfoPair());

            foreach (var entry in FightProps)
            {
                FightPropPair fightProp = new() { PropType = (uint)entry.Key, PropValue = (uint)entry.Value };
                entityInfo.FightPropList.Add(fightProp);
            }

            PropPair pair = new()
            {
                Type = (uint)PlayerProperty.PROP_LEVEL,
                PropValue = new() { Type = (uint)PlayerProperty.PROP_LEVEL, Val = (uint)Level, Ival = (uint)Level }
            };
            entityInfo.PropList.Add(pair);

            SceneMonsterInfo monsterInfo = new SceneMonsterInfo()
            {
                MonsterId = (uint)MonsterData.id,
                BlockId = BlockId == 0 ? 3001 : BlockId,
                GroupId = GroupId,
                ConfigId = ConfigId,
                AuthorityPeerId = Scene.World.Host.PeerId,
                PoseId = (uint)PoseId,
                InitPoseId = (uint)PoseId,
                BornType = MonsterBornType.Default,
                SpecialNameId = 40, // ??????????
            };
            MonsterData.affix.AsParallel().ForAll(w => monsterInfo.AffixList.Add((uint)w));

            if (GameData.MonsterDescribeDataMap.TryGetValue(MonsterData.id, out MonsterDescribeData describeData))
            {
                monsterInfo.TitleId = (uint)describeData.titleId;
            }

            if (RightWeaponEntityId != 0)
            {
                SceneWeaponInfo weaponInfo = new SceneWeaponInfo()
                {
                    EntityId = RightWeaponEntityId,
                    GadgetId = (uint)MonsterData.equips[0],
                    AbilityInfo = new()
                };

                monsterInfo.WeaponList.Add(weaponInfo);
            }
            if (LeftWeaponEntityId != 0)
            {
                SceneWeaponInfo weaponInfo = new SceneWeaponInfo()
                {
                    EntityId = LeftWeaponEntityId,
                    GadgetId = (uint)MonsterData.equips[1],
                    AbilityInfo = new()
                };

                monsterInfo.WeaponList.Add(weaponInfo);
            }

            entityInfo.Monster = monsterInfo;

            return entityInfo;
        }
    }
}
