using System.Numerics;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.Ability;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.GameServer.Systems.Inventory;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.World
{
    internal class AvatarEntity : SceneEntity
    {
        public readonly Avatar.Avatar Avatar;
        public TeamInfo TeamInfo { get; private set; }
        public uint KilledBy { get; protected set; }
        public override Vector3 Position { get => Avatar.Owner.Position; protected set => Avatar.Owner.Position = value; }
        public override Vector3 Rotation { get => Avatar.Owner.Rotation; protected set => Avatar.Owner.Rotation = value; }
        private float CachedLandingSpeed = 0;
        private long CachedLandingTimeMillisecond = 0;
        private bool monitorLandingEvent = false;

        public AvatarEntity(TeamInfo team, Scene scene, Avatar.Avatar avatar) : base(scene)
        {
            TeamInfo = team;
            Avatar = avatar;
            LiveState = LifeState.LIFE_ALIVE;
            EntityId = scene.World.GetNextEntityId(EntityIdType.AVATAR);
            FightProps = avatar.FightProp;
            WeaponItem weapon = avatar.GetWeapon();
            weapon.WeaponEntityId = scene.World.GetNextEntityId(EntityIdType.WEAPON);
            AbilityManager = new AvatarAbilityManager(this);
            AbilityManager.Initialize();
            Avatar.AsEntity = this;
        }

        public AvatarEntity(TeamInfo info, ushort index) : base(null)
        {
            TeamInfo = info;
            LiveState = LifeState.LIFE_ALIVE;
            Avatar = info.AvatarInfo[index];
            FightProps = Avatar.FightProp;
        }

        public override async Task MoveAsync(EntityMoveInfo moveInfo)
        {
            await base.MoveAsync(moveInfo);
            MotionState = moveInfo.MotionInfo.State;
            LastMoveReliableSeq = moveInfo.ReliableSeq;
            LastMoveSceneTimeMs = moveInfo.SceneTime;
            await Avatar.Owner.StaminaManager.HandleMoveInfoAsync(moveInfo);

            // TODO: handle MOTION_FIGHT landing which has a different damage factor
            // 		Also, for plunge attacks, LAND_SPEED is always -30 and is not useful.
            //  	May need the height when starting plunge attack.

            // MOTION_LAND_SPEED and MOTION_FALL_ON_GROUND arrive in different packets.
            // Cache land speed for later use.
            if (MotionState == MotionState.LandSpeed)
            {
                CachedLandingSpeed = moveInfo.MotionInfo.Speed.Y;
                CachedLandingTimeMillisecond = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                monitorLandingEvent = true;
            }
            if (monitorLandingEvent)
            {
                if (moveInfo.MotionInfo.State == MotionState.FallOnGround)
                {
                    monitorLandingEvent = false;
                    await HandleFallOnGround();
                }
            }
        }

        private async Task HandleFallOnGround()
        {
        }
        public override async Task OnDeathAsync(uint killerId = default)
        {
            KilledBy = killerId;
            await ClearEnergy(ChangeEnergyReason.None);
        }


        public override async Task<float> HealAsync(float amount)
        {
            // Do not heal character if they are dead
            if (LiveState == LifeState.LIFE_DEAD)
            {
                return 0f;
            }

            float healed = await base.HealAsync(amount);

            if (healed > 0f)
            {
                await Scene.BroadcastPacketAsync(
                    new PacketEntityFightPropChangeReasonNotify(this, FightProperty.FIGHT_PROP_CUR_HP, healed, PropChangeReason.Ability, ChangeHpReason.AddAbility)
                );
            }

            return healed;
        }

        public async Task ClearEnergy(ChangeEnergyReason reason)
        {
            // Fight props.
            FightProperty curEnergyProp = Avatar.GetCurSkillDepot().Element.CurEnergyProp;

            // Get max energy.
            float maxEnergy = Avatar.GetCurSkillDepot().Element.MaxEnergy;

            // Set energy to zero.
            await Avatar.SetCurrentEnergy(0);

            // Send packets.
            await Scene.BroadcastPacketAsync(new PacketEntityFightPropUpdateNotify(this, curEnergyProp));

            if (reason == ChangeEnergyReason.SkillStart)
            {
                await Scene.BroadcastPacketAsync(new PacketEntityFightPropChangeReasonNotify(this, curEnergyProp, -maxEnergy, reason));
            }
        }

        public async Task AddEnergyAsync(float amount, PropChangeReason reason, bool isFlat = false)
        {
            float curEnergy = Avatar.GetCurrentEnergy();
            float maxEnergy = Avatar.GetCurSkillDepot().Element.MaxEnergy;

            // Get energy recharge.
            float energyRecharge = Avatar.FightProp[FightProperty.FIGHT_PROP_CHARGE_EFFICIENCY];

            // Scale amount by energy recharge, if the amount is not flat.
            if (!isFlat)
            {
                amount *= energyRecharge;
            }

            // Determine the new energy value.
            float newEnergy = Math.Min(curEnergy + amount, maxEnergy);

            // Set energy and notify.
            if (newEnergy != curEnergy)
            {
                await Avatar.SetCurrentEnergy(newEnergy);

                await Scene.BroadcastPacketAsync(new PacketAvatarFightPropUpdateNotify(Avatar, Avatar.GetCurSkillDepot().Element.CurEnergyProp));
                await Scene.BroadcastPacketAsync(new PacketEntityFightPropChangeReasonNotify(this, Avatar.GetCurSkillDepot().Element.CurEnergyProp, newEnergy, reason));
            }
        }

        public SceneAvatarInfo GetSceneAvatarInfo()
        {
            SceneAvatarInfo avatarInfo = new SceneAvatarInfo()
            {
                Uid = (uint)Avatar.Owner.GameUid,
                AvatarId = (uint)Avatar.AvatarId,
                Guid = Avatar.Guid,
                PeerId = Avatar.Owner.PeerId,
                CostumeId = (uint)Avatar.Costume,
                WearingFlycloakId = (uint)Avatar.FlyCloak,
                BornTime = (uint)Avatar.BornTime,
                SkillDepotId = (uint)Avatar.CurrentDepotId,
                CoreProudSkillLevel = Avatar.GetCurSkillDepot().GetCoreProudSkillLevel(),
                /* TODO
                AnimHash =,
                CurVehicleInfo =,
                EquipIdList =,
                ExcelInfo =,
                ServerBuffList =,
                */
            };
            foreach (var talent in Avatar.GetCurSkillDepot().Talents) avatarInfo.TalentIdList.Add((uint)talent);
            foreach (var skill in Avatar.GetCurSkillDepot().Skills) avatarInfo.SkillLevelMap.Add((uint)skill.Key, (uint)skill.Value);
            foreach (var proudSkill in Avatar.GetCurSkillDepot().InherentProudSkillOpens) avatarInfo.InherentProudSkillList.Add((uint)proudSkill.proudSkillId);
            foreach (var extra in Avatar.GetCurSkillDepot().ProudSkillExtraLevelMap) avatarInfo.ProudSkillExtraLevelMap.Add((uint)extra.Key, (uint)extra.Value);
            TeamInfo.TeamResonances.AsParallel().ForAll(w => avatarInfo.TeamResonanceList.Add((uint)w.teamResonanceId));

            foreach (EquipItem item in Avatar.Equips.Values)
            {
                if (item.ItemData.itemType == ItemType.ITEM_WEAPON)
                {
                    avatarInfo.Weapon = (item as WeaponItem).CreateSceneWeaponInfo();
                }
                else
                {
                    avatarInfo.ReliquaryList.Add((item as ReliquaryItem).CreateSceneReliquaryInfo());
                }
                avatarInfo.EquipIdList.Add((uint)item.ItemId);
            }

            return avatarInfo;
        }

        public override SceneEntityInfo ToProto()
        {
            //TODO
            EntityAuthorityInfo authority = new EntityAuthorityInfo()
            {
                AbilityInfo = new AbilitySyncStateInfo(),
                RendererChangedInfo = new(),
                AiInfo = new() { IsAiOpen = true, BornPos = new() },
                BornPos = new()
            };

            //TODO
            SceneEntityInfo entityInfo = new SceneEntityInfo()
            {
                EntityId = EntityId,
                EntityType = ProtEntityType.Avatar,
                EntityClientData = new(),
                EntityAuthorityInfo = authority,
                LastMoveSceneTimeMs = LastMoveSceneTimeMs,
                LastMoveReliableSeq = LastMoveReliableSeq,
                LifeState = (uint)LiveState,
            };
            entityInfo.AnimatorParaList.Add(new AnimatorParameterValueInfoPair());

            if (Scene != null && Avatar.Owner.TeamManager.GetCurrentAvatarEntity() == this)
            {
                entityInfo.MotionInfo = GetMotionInfo();
            }
            else
            {
                entityInfo.MotionInfo = new() { Pos = new(), Rot = new(), Speed = new() };
            }

            foreach (var entry in FightProps)
            {
                FightPropPair fightProp = new FightPropPair() { PropType = (uint)entry.Key, PropValue = entry.Value };
                entityInfo.FightPropList.Add(fightProp);
            }

            PropPair pair = new()
            {
                Type = (uint)PlayerProperty.PROP_LEVEL,
                PropValue = new() { Type = (uint)PlayerProperty.PROP_LEVEL, Ival = Avatar.Level, Val = Avatar.Level }
            };
            entityInfo.PropList.Add(pair);

            entityInfo.Avatar = GetSceneAvatarInfo();

            return entityInfo;
        }

        public AbilityControlBlock GetAbilityControlBlock()
        {

            AbilityControlBlock abilityControlBlock = new AbilityControlBlock();
            uint embryoId = 0;

            // Add team resonances
            //TODO apply properly
            foreach (var resonance in TeamInfo.TeamResonances)
            {
                AbilityEmbryo emb = new()
                {
                    AbilityId = ++embryoId,
                    AbilityNameHash = (uint)Utils.AbilityHash(resonance.openConfig),
                    AbilityOverrideNameHash = (uint)GameServer.Configuration.Server.GameOptions.Constants.DEFAULT_ABILITY_NAME
                };

                abilityControlBlock.AbilityEmbryoList.Add(emb);
            }
            // Add skill depot abilities

            foreach (int hash in Avatar.GetCurSkillDepot().Abilities.Keys)
            {
                AbilityEmbryo emb = new AbilityEmbryo()
                {
                    AbilityId = ++embryoId,
                    AbilityNameHash = (uint)hash,
                    AbilityOverrideNameHash = (uint)GameServer.Configuration.Server.GameOptions.Constants.DEFAULT_ABILITY_NAME
                };
                abilityControlBlock.AbilityEmbryoList.Add(emb);
            }

            // Add equip abilities
            if (Avatar.EquipOpenConfigs != null)
            {
                foreach (string ability in Avatar.EquipOpenConfigs)
                {
                    AbilityEmbryo emb = new AbilityEmbryo()
                    {
                        AbilityId = ++embryoId,
                        AbilityNameHash = (uint)Utils.AbilityHash(ability),
                        AbilityOverrideNameHash = (uint)GameServer.Configuration.Server.GameOptions.Constants.DEFAULT_ABILITY_NAME
                    };

                    abilityControlBlock.AbilityEmbryoList.Add(emb);
                }
            }

            return abilityControlBlock;
        }
    }
}
