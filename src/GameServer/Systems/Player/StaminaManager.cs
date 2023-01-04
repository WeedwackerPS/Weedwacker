using System.Numerics;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Player
{
    //TODO scrap and do correctly
    internal class StaminaManager
    {
        public Player Owner { get; private set; }

        public StaminaManager(Player owner)
        {
            Owner = owner;
            PreviousPos = CurrentPos;
        }

        Vector3 CurrentPos { get => Owner.Position; set => Owner.Position = value; }

        // TODO: Skiff state detection?
        private static Dictionary<string, HashSet<MotionState>> MotionStatesCategorized = new()
        {
            {"CLIMB", new HashSet<MotionState>(){
                MotionState.Climb, // sustained, when not moving no cost no recover
                MotionState.StandbyToClimb // NOT OBSERVED, see MOTION_JUMP_UP_WALL_FOR_STANDBY
            } },
            {"DASH", new HashSet<MotionState>(){
                MotionState.DangerDash, // sustained
                MotionState.Dash // sustained
            } },
            {"FLY", new HashSet<MotionState>(){
                MotionState.Fly, // sustained
                MotionState.FlyFast, // sustained
                MotionState.FlySlow, // sustained
                MotionState.PoweredFly // sustained, recover
            } },
            {"RUN", new HashSet<MotionState>(){
                MotionState.DangerRun, // sustained, recover
                MotionState.Run // sustained, recover
            } },
            {"SKIFF", new HashSet<MotionState>(){
                MotionState.SkiffBoarding, // NOT OBSERVED even when boarding
                MotionState.SkiffDash, // sustained, observed with waverider entity ID.
                MotionState.SkiffNormal, // sustained, OBSERVED when both normal and dashing
                MotionState.SkiffPoweredDash // sustained, recover
            } },
            {"STANDBY", new HashSet<MotionState>(){
                MotionState.DangerStandbyMove, // sustained, recover
                MotionState.DangerStandby, // sustained, recover
                MotionState.LadderToStandby, // NOT OBSERVED
                MotionState.StandbyMove, // sustained, recover
                MotionState.Standby, // sustained, recover
            } },
            {"SWIM", new HashSet<MotionState>(){
                MotionState.SwimIdle, // sustained
                MotionState.SwimDash, // immediate and sustained
                MotionState.SwimJump, // NOT OBSERVED
                MotionState.SwimMove // sustained
            } },
            {"WALK", new HashSet<MotionState>(){
                MotionState.DangerWalk, // sustained, recover
                MotionState.Walk // sustained, recover
            } },
            {"OTHER", new HashSet<MotionState>(){
                MotionState.ClimbJump, // cost only once if repeated without switching state
                MotionState.DashBeforeShake, // immediate one time sprint charge.
                MotionState.Fight, // immediate, if sustained then subsequent will be MOTION_NOTIFY
                MotionState.JumpUpWallForStandby, // immediate, observed when RUN/WALK->CLIMB
                MotionState.Notify, // can be either cost or recover - check previous state and check skill casting
                MotionState.SitIdle, // sustained, recover
                MotionState.Jump // recover
            } },
            {"NOCOST_NORECOVER", new HashSet<MotionState>(){
                MotionState.LadderSlip, // NOT OBSERVED
                MotionState.Slip, // sustained, no cost no recover
                MotionState.FlyIdle // NOT OBSERVED
            } },
            {"IGNORE", new HashSet<MotionState>(){
                // these states have no impact on stamina
                MotionState.CrouchIdle,
                MotionState.CrouchMove,
                MotionState.CrouchRoll,
                MotionState.DestroyVehicle,
                MotionState.FallOnGround,
                MotionState.FollowRoute,
                MotionState.ForceSetPos,
                MotionState.GoUpstairs,
                MotionState.JumpOffWall,
                MotionState.LadderIdle,
                MotionState.LadderMove,
                MotionState.LandSpeed,
                MotionState.MoveFailAck,
                MotionState.None,
                MotionState.Num,
                MotionState.QuestForceDrag,
                MotionState.Reset,
                MotionState.StandbyToLadder,
                MotionState.Waterfall
            } },
        };

        public static int GlobalCharacterMaximumStamina => PlayerPropertyManager.MAX_MAX_STAMINA;
        public static int GlobalVehicleMaxStamina => PlayerPropertyManager.MAX_MAX_STAMINA;
        private Vector3 PreviousPos;
        private MotionState CurrentState = MotionState.Standby;
        private MotionState PreviousState = MotionState.Standby;
        private int StaminaRecoverDelay = 0;

        private uint VehicleId = default;
        public int VehicleStamina { get; private set; } = GlobalVehicleMaxStamina;

        public int GetMaxCharacterStamina()
        {
            return Owner.PlayerProperties.GetValueOrDefault(PlayerProperty.PROP_MAX_STAMINA, 10000);
        }

        public int GetCurrentCharacterStamina()
        {
            return Owner.PlayerProperties.GetValueOrDefault(PlayerProperty.PROP_CUR_PERSIST_STAMINA, 0);
        }

        public async Task<bool> AddCurrentStamina(int amount)
        {
            int cur = GetCurrentCharacterStamina();
            int max = GetMaxCharacterStamina();
            if (cur >= max) return false;
            int value = cur + amount;
            if (value > max)
                value = max;
            await Owner.PropManager.SetPropertyAsync(PlayerProperty.PROP_CUR_PERSIST_STAMINA, value);
            return true;
        }
        private bool IsPlayerMoving()
        {
            return false;//!CurrentPos.AlmostEquals(PreviousPos, 0.3f); // why 0.3f?
        }
        public async Task<int> UpdateStaminaRelative(StaminaDelta consumption, bool isCharacterStamina)
        {
            int currentStamina = isCharacterStamina ? GetCurrentCharacterStamina() : VehicleStamina;
            if (consumption == 0)
            {
                return currentStamina;
            }
            int maxStamina = isCharacterStamina ? GetMaxCharacterStamina() : GlobalVehicleMaxStamina;
            Logger.DebugWriteLine((isCharacterStamina ? "C " : "V ") + $"{currentStamina}/{maxStamina}\t{CurrentState}\t" +
                    (IsPlayerMoving() ? "moving" : "      ") + $"\t({consumption}, {(int)consumption})");
            int newStamina = currentStamina + (int)consumption;
            if (newStamina < 0)
            {
                newStamina = 0;
            }
            else if (newStamina > maxStamina)
            {
                newStamina = maxStamina;
            }
            return await SetStamina(newStamina, isCharacterStamina);
        }

        public async Task<int> UpdateStaminaAbsolute(int newStamina, bool isCharacterStamina)
        {
            int currentStamina = isCharacterStamina ? GetCurrentCharacterStamina() : VehicleStamina;
            int maxStamina = isCharacterStamina ? GetMaxCharacterStamina() : GlobalVehicleMaxStamina;
            if (newStamina < 0)
            {
                newStamina = 0;
            }
            else if (newStamina > maxStamina)
            {
                newStamina = maxStamina;
            }
            return await SetStamina(newStamina, isCharacterStamina);
        }

        // Returns new stamina and sends PlayerPropNotify or VehicleStaminaNotify
        public async Task<int> SetStamina(int newStamina, bool isCharacterStamina)
        {
            // Set stamina if is character stamina
            if (isCharacterStamina)
            {
                await Owner.PropManager.SetPropertyAsync(PlayerProperty.PROP_CUR_PERSIST_STAMINA, newStamina);
            }
            else
            {
                VehicleStamina = newStamina;
                await Owner.SendPacketAsync(new PacketVehicleStaminaNotify(VehicleId, ((float)newStamina) / 100));
            }

            return newStamina;
        }

        internal async Task HandleMoveInfoAsync(EntityMoveInfo moveInfo)
        {
            MotionInfo motionInfo = moveInfo.MotionInfo;
            MotionState motionState = motionInfo.State;
            uint notifyEntityId = moveInfo.EntityId;
            uint currentAvatarEntityId = Owner.TeamManager.CurrentAvatarEntity.EntityId;
            if (notifyEntityId != currentAvatarEntityId && notifyEntityId != VehicleId)
            {
                return;
            }
            CurrentState = motionState;
            Shared.Network.Proto.Vector? posVector = motionInfo.Pos;
            if (posVector != null)
                CurrentPos = new(posVector.X, posVector.Y, posVector.Z);
            await HandleImmediateStamina(motionState);
        }
        public async Task HandleVehicleInteractReq(uint vehicleId, VehicleInteractType vehicleInteractType)
        {
            if (vehicleInteractType == VehicleInteractType.In)
            {
                VehicleId = vehicleId;
                // Reset character stamina here to prevent falling into water immediately on ejection if char stamina is
                //      close to empty when boarding.
                await UpdateStaminaAbsolute(GetMaxCharacterStamina(), true);
                await UpdateStaminaAbsolute(GlobalVehicleMaxStamina, false);
            }
            else
            {
                VehicleId = default;
            }
        }

        private async Task HandleImmediateStamina(MotionState motionState)
        {
            if (CurrentState == motionState) return;
            switch (motionState)
            {
                case MotionState.Climb:
                    await UpdateStaminaRelative(StaminaDelta.CLIMB_START, true);
                    break;
                case MotionState.DashBeforeShake:
                    await UpdateStaminaRelative(StaminaDelta.DASH, true);
                    break;
                case MotionState.ClimbJump:
                    await UpdateStaminaRelative(StaminaDelta.CLIMB_JUMP, true);
                    break;
                case MotionState.SwimDash:
                    await UpdateStaminaRelative(StaminaDelta.SWIM_DASH_START, true);
                    break;
            }
        }

        public async Task OnTickAsync()
        {
            bool moving = IsPlayerMoving();
            int currentCharacterStamina = GetCurrentCharacterStamina();
            int maxCharacterStamina = GetMaxCharacterStamina();
            int currentVehicleStamina = VehicleStamina;
            int maxVehicleStamina = GlobalVehicleMaxStamina;
            if (moving || (currentCharacterStamina < maxCharacterStamina) || (currentVehicleStamina < maxVehicleStamina))
            {
                Logger.DebugWriteLine("Player moving: " + moving + ", stamina full: " +
                        (currentCharacterStamina >= maxCharacterStamina) + ", recalculate stamina");
                bool isCharacterStamina = true;
                StaminaDelta consumption;
                if (MotionStatesCategorized["CLIMB"].Contains(CurrentState))
                {
                    consumption = GetClimbConsumption();
                }
                else if (MotionStatesCategorized["DASH"].Contains(CurrentState))
                {
                    consumption = GetDashConsumption();
                }
                else if (MotionStatesCategorized["FLY"].Contains(CurrentState))
                {
                    consumption = GetFlyConsumption();
                }
                else if (MotionStatesCategorized["RUN"].Contains(CurrentState))
                {
                    consumption = StaminaDelta.RUN;
                }
                else if (MotionStatesCategorized["SKIFF"].Contains(CurrentState))
                {
                    consumption = GetSkiffConsumption();
                    isCharacterStamina = false;
                }
                else if (MotionStatesCategorized["STANDBY"].Contains(CurrentState))
                {
                    consumption = StaminaDelta.STANDBY;
                }
                else if (MotionStatesCategorized["SWIM"].Contains(CurrentState))
                {
                    consumption = GetSwimConsumptions();
                }
                else if (MotionStatesCategorized["WALK"].Contains(CurrentState))
                {
                    consumption = StaminaDelta.WALK;
                }
                else if (MotionStatesCategorized["NOCOST_NORECOVER"].Contains(CurrentState))
                {
                    consumption = StaminaDelta.None;
                }
                else if (MotionStatesCategorized["OTHER"].Contains(CurrentState))
                {
                    consumption = GetOtherConsumptions();
                }
                else
                { // ignore
                    return;
                }
                // Delay 1 seconds before starts recovering stamina
                if (consumption != 0)
                {
                    if (consumption < 0)
                    {
                        StaminaRecoverDelay = 0;
                    }
                    if (consumption > 0
                            && consumption != StaminaDelta.POWERED_FLY
                            && consumption != StaminaDelta.POWERED_SKIFF)
                    {
                        // For POWERED_* recover immediately - things like Amber's gliding exam and skiff challenges may require this.
                        if (StaminaRecoverDelay < 5)
                        {
                            // For others recover after 1 seconds (5 ticks) - as official server does.
                            StaminaRecoverDelay++;
                            consumption = 0;
                            Logger.DebugWriteLine("Delaying recovery: " + StaminaRecoverDelay);
                        }
                    }
                    await UpdateStaminaRelative(consumption, isCharacterStamina);
                }
            }
            PreviousState = CurrentState;
            PreviousPos = CurrentPos;
        }

        private void HandleDrowning()
        {
            // TODO: fix drowning waverider entity
            int stamina = GetCurrentCharacterStamina();
            if (stamina < 10)
            {
                Logger.DebugWriteLine(GetCurrentCharacterStamina() + "/" +
                        GetMaxCharacterStamina() + "\t" + CurrentState);
                if (CurrentState != MotionState.SwimIdle)
                {
                    //killAvatar(cachedEntity, PlayerDieType.Drawn);
                }
            }
        }

        // Consumption Calculators

        // Stamina Consumption Reduction: https://genshin-impact.fandom.com/wiki/Stamina

        private StaminaDelta GetFightConsumption()
        {
            Avatar.Avatar currentAvatar = Owner.TeamManager.CurrentAvatarEntity.Avatar;

            return currentAvatar.Data.GeneralData.weaponType switch
            {
                WeaponType.WEAPON_BOW => StaminaDelta.None,
                WeaponType.WEAPON_CLAYMORE => StaminaDelta.CLAYMORE_CHARGED,
                WeaponType.WEAPON_CATALYST => StaminaDelta.CATALYST_CHARGED,
                WeaponType.WEAPON_POLE => StaminaDelta.POLEARM_CHARGED,
                WeaponType.WEAPON_SWORD_ONE_HAND => StaminaDelta.SWORD_CHARGED,
                _ => StaminaDelta.None,
            };
            ;
        }

        private StaminaDelta GetClimbConsumption()
        {
            StaminaDelta consumption = StaminaDelta.None;
            if (CurrentState == MotionState.Climb && IsPlayerMoving())
            {
                consumption = StaminaDelta.CLIMBING;
            }
            return consumption;
        }

        private StaminaDelta GetSwimConsumptions()
        {
            HandleDrowning();
            StaminaDelta consumption = StaminaDelta.None;
            if (CurrentState == MotionState.SwimMove)
            {
                consumption = StaminaDelta.SWIMMING;
            }
            if (CurrentState == MotionState.SwimDash)
            {
                consumption = StaminaDelta.SWIM_DASH;
            }
            return consumption;
        }

        private StaminaDelta GetDashConsumption()
        {
            StaminaDelta consumption = StaminaDelta.None;
            if (CurrentState == MotionState.Dash)
            {
                consumption = StaminaDelta.DASH;
            }
            return consumption;
        }

        private StaminaDelta GetFlyConsumption()
        {
            // POWERED_FLY, e.g. wind tunnel
            if (CurrentState == MotionState.PoweredFly)
                return StaminaDelta.POWERED_FLY;
            else
                return StaminaDelta.FLY;
        }

        private StaminaDelta GetSkiffConsumption()
        {
            // No known reduction for skiffing.
            return CurrentState switch
            {
                MotionState.SkiffDash => StaminaDelta.SKIFF_DASH,
                MotionState.SkiffPoweredDash => StaminaDelta.POWERED_SKIFF,
                MotionState.SkiffNormal => StaminaDelta.SKIFF,
                _ => StaminaDelta.None,
            };
        }

        private StaminaDelta GetOtherConsumptions()
        {
            switch (CurrentState)
            {
                case MotionState.Notify:
                    break;
                case MotionState.Fight:
                    // TODO: what if charged attack
                    return GetFightConsumption();
            }

            return StaminaDelta.None;
        }
    }
}