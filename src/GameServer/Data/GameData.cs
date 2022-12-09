using System.Collections.Concurrent;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using NLua;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.AttackPatterns;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.BornTypes;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.DirectionTypes;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.EventOps;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.SelectTargetType;
using Weedwacker.GameServer.Data.BinOut.AbilityGroup;
using Weedwacker.GameServer.Data.BinOut.Avatar;
using Weedwacker.GameServer.Data.BinOut.Scene.Point;
using Weedwacker.GameServer.Data.BinOut.Scene.SceneNpcBorn;
using Weedwacker.GameServer.Data.BinOut.Talent;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Systems.Script.Scene;
using Weedwacker.Shared.Utils;
using static Weedwacker.GameServer.Data.SerializationSettings;

namespace Weedwacker.GameServer.Data
{
    internal static class GameData
    {
        //Avatar//
        //---------------------------------------------------------------------------------------------------------------------------------//
        public readonly static SortedList<int, AvatarCodexData> AvatarCodexDataMap = new(); // sortId
        public readonly static SortedList<int, AvatarCostumeData> AvatarCostumeDataMap = new(); // costumeId
        public readonly static SortedList<int, AvatarCurveData> AvatarCurveDataMap = new(); // level
        public readonly static SortedList<int, AvatarData> AvatarDataMap = new(); // AvatarId
        public readonly static SortedList<int, AvatarFetterLevelData> AvatarFetterLevelDataMap = new(); // level
        public readonly static SortedList<int, AvatarFlycloakData> AvatarFlycloakDataMap = new(); // flycloakId
        public readonly static SortedList<int, AvatarLevelData> AvatarLevelDataMap = new(); // Level
        public readonly static SortedList<Tuple<int, int>, AvatarPromoteData> AvatarPromoteDataMap = new(); // <<PromoteId,promoteLevel>,Data>
        public readonly static SortedList<int, AvatarSkillData> AvatarSkillDataMap = new(); // SkillId
        public readonly static SortedList<int, AvatarSkillDepotData> AvatarSkillDepotDataMap = new(); // SkillDepotId
        public readonly static ConcurrentDictionary<string, Dictionary<string, BaseConfigTalent[]>> AvatarTalentConfigDataMap = new(); // file name
        public readonly static SortedList<int, AvatarTalentData> AvatarTalentDataMap = new(); // talentId
        public readonly static ConcurrentDictionary<string, ConfigAbilityContainer[]> ConfigAbilityAvatarMap = new(); // file name
        public readonly static SortedList<int, FetterCharacterCardData> FetterCharacterCardDataMap = new(); // avatarId
        public readonly static SortedList<int, FetterInfoData> FetterInfoDataMap = new(); // fetterId
        public readonly static SortedList<int, FettersData> FettersDataMap = new(); // fetterId
        public readonly static SortedList<int, FetterStoryData> FetterStoryDataMap = new(); // fetterId
        public readonly static SortedList<int, PhotographExpressionData> PhotographExpressionDataMap = new(); // fetterId
        public readonly static SortedList<int, PhotographPosenameData> PhotographPosenameDataMap = new(); // fetterId
        public readonly static SortedList<int, ProudSkillData> ProudSkillDataMap = new(); // proudSkillId
        //---------------------------------------------------------------------------------------------------------------------------------//
        public readonly static ConcurrentDictionary<string, AbilityGroupData> AbilityGroupDataMap = new(); // skillDepotAbilityGroup name
        public readonly static SortedList<int, AvatarHeroEntityData> AvatarHeroEntityDataMap = new();
        public readonly static ConcurrentDictionary<string, ConfigAvatar> ConfigAvatarMap = new();
        public readonly static SortedList<int, DungeonData> DungeonDataMap = new(); // id
        public readonly static SortedList<int, EnvAnimalGatherData> EnvAnimalGatherDataMap = new(); // animalId
        public readonly static SortedList<int, EquipAffixData> EquipAffixDataMap = new(); // affixId
        public readonly static SortedList<Tuple<int, int>, GatherData> GatherDataMap = new(); // <id, gadgetId>
        public readonly static SortedList<int, GadgetData> GadgetDataMap = new(); // id
        public static GlobalCombatData GlobalCombatData { get; private set; }
        public readonly static SortedList<int, HomeWorldFurnitureData> HomeWorldFurnitureDataMap = new(); // id
        public readonly static SortedList<int, ItemData> ItemDataMap = new(); // id ItemData is subclassed, and loaded as MaterialData, ReliquaryData, and WeaponData
        public readonly static SortedList<int, MonsterCurveData> MonsterCurveDataMap = new(); // level
        public readonly static SortedList<int, MonsterData> MonsterDataMap = new(); // id
        public readonly static SortedList<int, MonsterDescribeData> MonsterDescribeDataMap = new(); // id
        public readonly static SortedList<int, OpenStateData> OpenStateDataMap = new(); // id
        public readonly static SortedList<string, BaseConfigTalent[]> RelicAffixConfigDataMap = new(); // openConfig
        public readonly static SortedList<int, ShopData> ShopDataMap = new(); // shopId
        public readonly static SortedList<int, RewardData> RewardDataMap = new(); // RewardId
        public readonly static SortedList<int, ShopGoodsData> ShopGoodsDataMap = new(); // goodsId
        public readonly static ConcurrentDictionary<string, BaseConfigTalent[]> TeamResonanceConfigDataMap = new(); // openConfig
        public readonly static SortedList<int, ReliquaryAffixData> ReliquaryAffixDataMap = new(); // id
        public readonly static SortedList<int, ReliquaryMainPropData> ReliquaryMainPropDataMap = new(); // id
        public readonly static SortedList<Tuple<int, int>, ReliquaryLevelData> ReliquaryLevelDataMap = new(); // <rank, level>
        public readonly static SortedList<int, ReliquarySetData> ReliquarySetDataMap = new(); // setid
        public readonly static SortedList<int, SceneData> SceneDataMap = new(); // id
        public readonly static ConcurrentDictionary<string, ScenePointData> ScenePointDataMap = new(); // filename
        public readonly static ConcurrentDictionary<int, SceneNpcBornData> SceneNpcBornDataMap = new(); // sceneId
        public readonly static SortedList<int, SceneTagData> SceneTagDataMap = new(); // id
        public readonly static SortedList<int, TeamResonanceData> TeamResonanceDataMap = new(); // teamResonanceId 
        public readonly static ConcurrentDictionary<string, BaseConfigTalent[]> WeaponAffixConfigDataMap = new(); // openConfig
        public readonly static SortedList<int, WeaponCurveData> WeaponCurveDataMap = new(); // level
        public readonly static SortedList<Tuple<int, int>, WeaponPromoteData> WeaponPromoteDataMap = new(); // <weaponPromoteId, promoteLevel>
        public readonly static SortedList<int, WeatherData> WeatherDataMap = new(); // areaId

        private readonly static SortedList<int, SceneInfo> SceneScripts = new();
        private static string ScriptPath;

        static readonly JsonSerializer Serializer = new()
        {
            // To handle $type
            TypeNameHandling = TypeNameHandling.Objects,
            SerializationBinder = new KnownTypesBinder
            {
                KnownTypes = new Type[] {
                    // Ability Types
                    typeof(AddAbility), typeof(AddTalentExtraLevel), typeof(ModifyAbility), typeof(ModifySkillCD), typeof(ModifySkillPoint), typeof(UnlockTalentParam),
                    typeof(UnlockControllerConditions),
                    // Point Types
                    typeof(DungeonEntry), typeof(DungeonExit), typeof(DungeonQuitPoint), typeof(DungeonSlipRevivePoint), typeof(DungeonWayPoint), typeof(SceneBuildingPoint),
                    typeof(SceneTransPoint), typeof(PersonalSceneJumpPoint), typeof(SceneVehicleSummonPoint), typeof(TransPointStatue), typeof(TransPointNormal),
                    typeof(VehicleSummonPoint), typeof(VirtualTransPoint),
                    // ConfigAbility
                    typeof(ConfigAbility),
                    // AbilityMixin
                    typeof(AttachToStateIDMixin), typeof(SkillButtonHoldChargeMixin), typeof(ButtonHoldChargeMixin), typeof(AttachToNormalizedTimeMixin), typeof(DoReviveMixin),
                    typeof(ModifyDamageMixin), typeof(OnAvatarUseSkillMixin), typeof(AvatarChangeSkillMixin), typeof(AttachToAnimatorStateIDMixin), typeof(AvatarSteerByCameraMixin),
                    typeof(AttachModifierToSelfGlobalValueMixin), typeof(TriggerElementSupportMixin), typeof(ModifySkillCDByModifierCountMixin), typeof(DoActionByKillingMixin),
                    typeof(DoActionByEnergyChangeMixin), typeof(ElementHittingOtherPredicatedMixin), typeof(RejectAttackMixin), typeof(DoActionByElementReactionMixin),
                    typeof(DoActionByStateIDMixin), typeof(DoActionByTeamStatusMixin), typeof(AttachModifierToPredicateMixin), typeof(DoActionByEventMixin), typeof(AutoDefenceMixin),
                    typeof(ExtendLifetimeByPickedGadgetMixin), typeof(ReviveElemEnergyMixin), typeof(ChangeFieldMixin), typeof(CostStaminaMixin), typeof(DoActionByAnimatorStateIDMixin),
                    typeof(SwitchSkillIDMixin), typeof(CurLocalAvatarMixin), typeof(GlobalMainShieldMixin), typeof(AttachToAbilityStateMixin), typeof(ReplaceEventPatternMixin),
                    typeof(ShaderLerpMixin), typeof(MoveStateMixin), typeof(CameraBlurMixin), typeof(GlobalSubShieldMixin), typeof(ModifyDamageCountMixin), typeof(EffectChangeAlphaMixin),
                    typeof(TriggerWeatherMixin), typeof(WindZoneMixin), typeof(AttackReviveEnergyMixin), typeof(ServerUpdateGlobalValueMixin), typeof(EliteShieldMixin),
                    typeof(DoActionByCreateGadgetMixin), typeof(CurLocalAvatarMixinV2), typeof(ApplyInertiaVelocityMixin), typeof(TriggerPostProcessEffectMixin), typeof(AttachToDayNightMixin),
                    typeof(VelocityDetectMixin), typeof(TriggerWitchTimeMixin), typeof(AttachToMonsterAirStateMixin), typeof(OnParentAbilityStartMixin), typeof(AIPerceptionMixin),
                    typeof(FieldEntityCountChangeMixin), typeof(StageReadyMixin), typeof(DoActionByGainCrystalSeedMixin),
                    // Actions
                    typeof(SetAnimatorTrigger), typeof(SetAnimatorInt), typeof(SetAnimatorBool), typeof(SetCameraLockTime), typeof(ResetAnimatorTrigger), typeof(RemoveModifier),
                    typeof(ApplyModifier), typeof(TriggerBullet), typeof(EntityDoSkill), typeof(AvatarSkillStart), typeof(Predicated), typeof(SetGlobalValue), typeof(AttachModifier),
                    typeof(KillSelf), typeof(TriggerAbility), typeof(UnlockSkill), typeof(RemoveUniqueModifier), typeof(FireAISoundEvent), typeof(TriggerAttackEvent), typeof(UseItem),
                    typeof(DamageByAttackValue), typeof(CreateGadget), typeof(ActCameraRadialBlur), typeof(FireEffect), typeof(KillGadget), typeof(TriggerHideWeapon), typeof(ClearGlobalValue),
                    typeof(ActCameraShake), typeof(DoWatcherSystemAction), typeof(AddGlobalValue), typeof(SetGlobalValueToOverrideMap), typeof(AddElementDurability), typeof(SetSelfAttackTarget),
                    typeof(FireHitEffect), typeof(SetGlobalPos), typeof(AvatarEnterCameraShot), typeof(AvatarCameraParam), typeof(LoseHP), typeof(AvatarDoBlink), typeof(SendEffectTrigger),
                    typeof(ModifyAvatarSkillCD), typeof(SetOverrideMapValue), typeof(DebugLog), typeof(CopyGlobalValue), typeof(SetTargetNumToGlobalValue), typeof(SetGlobalDir),
                    typeof(ReviveDeadAvatar), typeof(ReviveAvatar), typeof(Randomed), typeof(FireSubEmitterEffect), typeof(TriggerAudio), typeof(ReviveElemEnergy), typeof(EnableHeadControl),
                    typeof(AvatarExitCameraShot), typeof(ControlEmotion), typeof(SetAnimatorFloat), typeof(SetEmissionScaler), typeof(ClearEndura), typeof(ChangeShieldValue), typeof(Repeated),
                    typeof(TriggerSetPassThrough), typeof(TriggerSetVisible), typeof(FixedAvatarRushMove), typeof(TryTriggerPlatformStartMove), typeof(AttachEffect), typeof(ForceUseSkillSuccess),
                    typeof(AvatarEnterFocus), typeof(AvatarExitFocus), typeof(ServerLuaCall), typeof(EnableHitBoxByName), typeof(PlayEmoSync), typeof(AddAvatarSkillInfo), typeof(ChangePlayMode),
                    typeof(SetRandomOverrideMapValue), typeof(GenerateElemBall), typeof(HealHP), typeof(EnableBulletCollisionPluginTrigger), typeof(EnableMainInterface), typeof(RemoveAvatarSkillInfo),
                    typeof(AttachAbilityStateResistance), typeof(TriggerSetRenderersEnable), typeof(SetVelocityIgnoreAirGY), typeof(RemoveVelocityForce), typeof(CreateMovingPlatform),
                    typeof(TurnDirection), typeof(DungeonFogEffects), typeof(SendEffectTriggerToLineEffect), typeof(TriggerTaunt), typeof(ClearLockTarget), typeof(TriggerAttackTargetMapEvent),
                    typeof(EnablePushColliderName), typeof(TriggerSetShadowRamp), typeof(ReviveStamina), typeof(GetFightProperty), typeof(ChangeFollowDampTime), typeof(EnableRocketJump),
                    typeof(EnableAvatarMoveOnWater), typeof(DummyAction), typeof(EnableAfterImage), typeof(HideUIBillBoard), typeof(EnterCameraLock), typeof(EnablePartControl),
                    typeof(FireMonsterBeingHitAfterImage), typeof(EnableHDMesh), typeof(SendDungeonFogEffectTrigger),
                    // Predicate
                    typeof(ByAny), typeof(ByAnimatorInt), typeof(ByLocalAvatarStamina), typeof(ByEntityAppearVisionType), typeof(ByTargetGlobalValue),typeof(ByTargetPositionToSelfPosition),
                    typeof(ByCurrentSceneId), typeof(ByEntityTypes), typeof(ByIsTargetCamp), typeof(ByCurTeamHasFeatureTag), typeof(ByTargetHPRatio), typeof(BySkillReady), typeof(ByItemNumber),
                    typeof(ByTargetHPValue), typeof(ByHasAttackTarget), typeof(ByAttackNotHitScene), typeof(ByAvatarInWaterDepth), typeof(ByTargetOverrideMapValue), typeof(ByUnlockTalentParam),
                    typeof(ByAttackTags), typeof(ByTargetType), typeof(ByNot), typeof(ByHasChildGadget), typeof(ByHasElement), typeof(ByTargetIsCaster), typeof(ByAnimatorBool), typeof(ByTargetAltitude),
                    typeof(ByAvatarWeaponType), typeof(ByHasAbilityState), typeof(ByIsCombat), typeof(ByTargetIsSelf), typeof(ByAvatarElementType), typeof(ByTargetForwardAndSelfPosition),
                    typeof(ByTargetIsGhostToEnemy), typeof(ByIsLocalAvatar), typeof(ByTargetWeight), typeof(ByHitElement), typeof(ByEnergyRatio), typeof(ByHitDamage), typeof(ByHitEnBreak),
                    typeof(ByHitStrikeType), typeof(ByHitCritical), typeof(ByTargetConfigID), typeof(ByHitBoxType), typeof(ByAttackType), typeof(ByMonsterAirState),
                    // BornType
                    typeof(ConfigBornByTarget), typeof(ConfigBornByAttachPoint), typeof(ConfigBornBySelf), typeof(ConfigBornByCollisionPoint), typeof(ConfigBornBySelectedPoint),
                    typeof(ConfigBornByGlobalValue), typeof(ConfigBornBySelfOwner), typeof(ConfigBornByTargetLinearPoint), typeof(ConfigBornByHitPoint),
                    // DirectionType
                    typeof(ConfigDirectionByAttachPoint),
                    // SelectTargetType
                    typeof(SelectTargetsByEquipParts), typeof(SelectTargetsByShape), typeof(SelectTargetsByChildren),
                    // AttackPattern
                    typeof(ConfigAttackSphere), typeof(ConfigAttackCircle), typeof(ConfigAttackBox),
                    // EventOp
                    typeof(ConfigAudioEventOp), typeof(ConfigAudioPositionedEventOp),
                }
            }
        };
        public static async Task<SceneInfo?> GetSceneScriptsAsync(int sceneId)
        {
            if (SceneScripts.TryGetValue(sceneId, out SceneInfo? value))
            {
                return value;
            }
            else
            {
                await LoadSceneScripts(sceneId, ScriptPath);
                return SceneScripts[sceneId];
            }
        }
        static async Task LoadScripts(string path)
        {
            var dirs = Directory.GetDirectories(Path.Combine(path, "Scene"));
            var tasks = new List<Task>();

            foreach (var fileAndPath in dirs)
            {
                string fullPath = Path.GetFullPath(fileAndPath);
                int sceneId = int.Parse(fullPath.Split("\\").Last());
                if (GameServer.Configuration.Server.DynamicLoadScenes && sceneId != 3) continue;
                tasks.Add(LoadSceneScripts(sceneId, path));
            }

            await Task.WhenAll(tasks);
        }

        static async Task LoadSceneScripts(int sceneId, string scriptPath)
        {
            Lua lua = new();
            var SceneX = await SceneInfo.CreateAsync(lua, sceneId, scriptPath);
            SceneScripts.Add(sceneId, SceneX);
        }


        static async Task LoadBinOutFolder<Obj, Key>(string path, Func<Obj, Key> keySelector, IDictionary<Key, Obj> map) where Key : notnull
        {
            map.Clear();
            string[] filePaths = Directory.GetFiles(path, "*.json", SearchOption.TopDirectoryOnly);
            var tasks = new List<Task>();
            filePaths.AsParallel().ForAll(async file =>
            {
                var filePath = new FileInfo(file);
                using var sr = new StringReader(await File.ReadAllTextAsync(filePath.FullName));
                string fileName = filePath.Name;
                using var jr = new JsonTextReader(sr);
                var fileData = Serializer.Deserialize<Obj>(jr);

                Key key = keySelector(fileData);
                map.Add(key, fileData);
            });
        }

        static async Task LoadBinOutFolder<Obj>(string path, IDictionary<string, Obj> map, bool isDictionaryJson = true)
        {
            map.Clear();
            string[] filePaths = Directory.GetFiles(path, "*.json", SearchOption.TopDirectoryOnly);
            filePaths.AsParallel().ForAll(async file =>
            {
                var filePath = new FileInfo(file);
                using var sr = new StringReader(await File.ReadAllTextAsync(filePath.FullName));
                using var jr = new JsonTextReader(sr);
                if (isDictionaryJson)
                {
                    var fileData = Serializer.Deserialize<Dictionary<string, Obj>>(jr);
                    foreach (var data in fileData)
                    {
                        map.Add(data.Key, data.Value);
                    }
                }
                else
                {

                    var fileData = Serializer.Deserialize<Obj>(jr);
                    // Use the name (without ".json") of the file as the key
                    map.Add(Regex.Replace(filePath.Name, "\\.json", ""), fileData);

                    /*
                    try
                    {
                        var fileData = Serializer.Deserialize<Obj>(jr);
                        // Use the name (without ".json") of the file as the key
                        map.Add(Regex.Replace(filePath.Name, "\\.json", ""), fileData);
                    }
                    catch(Exception e)
                    {
                        Logger.DebugWriteLine(e.Message);
                    }*/
                }
            });
        }

        // To handle derived types
        static async Task LoadExcel<Obj, Key, DerivedType>(string path, Func<Obj, Key> keySelector, SortedList<Key, Obj> map) where Key : notnull where DerivedType : Obj
        {
            var ra = typeof(DerivedType).GetResourceData();
            if (ra == null || !ra.GetResourceFile(path, out var fi)) return;
            var objs = await LoadObjects<DerivedType[]>(fi);
            if (objs == null) return;
            foreach (var obj in objs)
                map.Add(keySelector(obj), obj);
        }
        static async Task LoadExcel<Obj, Key>(string path, Func<Obj, Key> keySelector, SortedList<Key, Obj> map) where Key : notnull
        {
            var ra = typeof(Obj).GetResourceData();
            if (ra == null || !ra.GetResourceFile(path, out var fi)) return;
            map.Clear();
            var objs = await LoadObjects<Obj[]>(fi);
            if (objs == null) return;
            foreach (var obj in objs)
                try
                {

                    map.Add(keySelector(obj), obj);
                }
                catch (Exception ex)
                {
                    Logger.WriteErrorLine(ex.Message);
                    Logger.WriteErrorLine(fi.Name);
                }
        }
        static async Task<T?> LoadObjects<T>(FileInfo fi)
        {
            using var sr = new StringReader(await File.ReadAllTextAsync(fi.FullName));
            using var jr = new JsonTextReader(sr);
            try
            {
                var ret = Serializer.Deserialize<T>(jr);
                return ret;
            }
            catch (Exception)
            {
                return default(T);
            }


        }
        static bool GetResourceFile(this ResourceAttribute ra, string path, out FileInfo fi)
        {
            var file = Path.Combine(path, ra.Names);
            fi = new(file);
            return fi.Exists;
        }
        static ResourceAttribute? GetResourceData(this Type res) => Attribute.GetCustomAttribute(res, typeof(ResourceAttribute)) as ResourceAttribute;
        public static async Task LoadAllResourcesAsync(string resourcesPath)
        {
            Logger.WriteLine("Loading Resources...");
            string excelPath = Path.Combine(resourcesPath, "ExcelBinOutput/");
            string binPath = Path.Combine(resourcesPath, "BinOutput/");
            ScriptPath = Path.Combine(resourcesPath, "Scripts/");

            var file = Path.Combine(binPath, "Common", "ConfigGlobalCombat.json");
            FileInfo fi = new(file);
            using var sr = new StringReader(await File.ReadAllTextAsync(fi.FullName));
            using var jr = new JsonTextReader(sr);
            GlobalCombatData = Serializer.Deserialize<GlobalCombatData>(jr);

            await Task.WhenAll(new Task[]
            {
                LoadExcel(excelPath, o => o.sortId, AvatarCodexDataMap),
                LoadExcel(excelPath, o => o.skinId, AvatarCostumeDataMap),
                LoadExcel(excelPath, o => o.level, AvatarCurveDataMap),
                LoadExcel(excelPath, o => o.id, AvatarDataMap),
                LoadExcel(excelPath, o => o.fetterLevel, AvatarFetterLevelDataMap),
                LoadExcel(excelPath, o => o.flycloakId, AvatarFlycloakDataMap),
                LoadExcel(excelPath, o => o.avatarId, AvatarHeroEntityDataMap),
                LoadExcel(excelPath, o => o.Level, AvatarLevelDataMap),
                LoadExcel(excelPath, o => Tuple.Create(o.avatarPromoteId, o.promoteLevel), AvatarPromoteDataMap),
                LoadExcel(excelPath, o => o.id, AvatarSkillDataMap),
                LoadExcel(excelPath, o => o.id, AvatarSkillDepotDataMap),
                LoadExcel(excelPath, o => o.talentId, AvatarTalentDataMap),
                LoadExcel(excelPath, o => o.id, DungeonDataMap),
                LoadExcel(excelPath, o => o.animalId, EnvAnimalGatherDataMap),
                LoadExcel(excelPath, o => o.affixId, EquipAffixDataMap),
                LoadExcel(excelPath, o => o.avatarId, FetterCharacterCardDataMap),
                LoadExcel(excelPath, o => o.fetterId, FetterInfoDataMap),
                LoadExcel(excelPath, o => o.fetterId, FettersDataMap),
                LoadExcel(excelPath, o => o.fetterId, FetterStoryDataMap),
                LoadExcel(excelPath, o => Tuple.Create(o.id, o.gadgetId), GatherDataMap),
                LoadExcel(excelPath, o => o.id, GadgetDataMap),
                LoadExcel(excelPath, o => o.id, HomeWorldFurnitureDataMap),
                LoadExcel<ItemData, int, MaterialData>(excelPath, o => o.id, ItemDataMap),
                LoadExcel(excelPath, o => o.level, MonsterCurveDataMap),
                LoadExcel(excelPath, o => o.id, MonsterDataMap),
                LoadExcel(excelPath, o => o.id, MonsterDescribeDataMap),
                LoadExcel(excelPath, o => o.id, OpenStateDataMap),
                LoadExcel(excelPath, o => o.fetterId, PhotographExpressionDataMap),
                LoadExcel(excelPath, o => o.fetterId, PhotographPosenameDataMap),
                LoadExcel(excelPath, o => o.proudSkillId, ProudSkillDataMap),
                LoadExcel<ItemData, int, ReliquaryData>(excelPath, o => o.id, ItemDataMap),
                LoadExcel(excelPath, o => o.id, ReliquaryAffixDataMap),
                LoadExcel(excelPath, o => o.id, ReliquaryMainPropDataMap),
                LoadExcel(excelPath, o => Tuple.Create(o.rank, o.level), ReliquaryLevelDataMap),
                LoadExcel(excelPath, o => o.setId, ReliquarySetDataMap),
                LoadExcel(excelPath, o => o.rewardId, RewardDataMap),
                LoadExcel(excelPath, o => o.id, SceneDataMap),
                LoadExcel(excelPath, o => o.id, SceneTagDataMap),
                LoadExcel(excelPath, o => o.shopId, ShopDataMap),
                LoadExcel(excelPath, o=> o.goodsId, ShopGoodsDataMap),
                LoadExcel(excelPath, o => o.teamResonanceId, TeamResonanceDataMap),
                LoadExcel<ItemData, int, WeaponData>(excelPath, o => o.id, ItemDataMap),
                LoadExcel(excelPath, o => o.level, WeaponCurveDataMap),
                LoadExcel(excelPath, o => Tuple.Create(o.weaponPromoteId, o.promoteLevel), WeaponPromoteDataMap),
                LoadExcel(excelPath, o => o.areaId, WeatherDataMap),

                LoadBinOutFolder(Path.Combine(binPath, "Ability", "Temp", "AvatarAbilities"), ConfigAbilityAvatarMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Scene/SceneNpcBorn"), o => o.sceneId,  SceneNpcBornDataMap),
                LoadBinOutFolder(Path.Combine(binPath, "AbilityGroup"), AbilityGroupDataMap),
                LoadBinOutFolder(Path.Combine(binPath, "Talent/AvatarTalents"), AvatarTalentConfigDataMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Avatar"), ConfigAvatarMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Talent/EquipTalents"), WeaponAffixConfigDataMap),
                LoadBinOutFolder(Path.Combine(binPath, "Talent/RelicTalents"), RelicAffixConfigDataMap),
                LoadBinOutFolder(Path.Combine(binPath, "Talent/TeamTalents"), TeamResonanceConfigDataMap),
                LoadBinOutFolder(Path.Combine(binPath, "Scene/Point"), ScenePointDataMap, false),

                LoadScripts(ScriptPath)
            });
            Logger.WriteLine("Initializing ConfigAbility local ids...");
            var tasks = new List<Task>();
            foreach (var container in ConfigAbilityAvatarMap.Values)
            {
                foreach (var config in container)
                {
                    tasks.Add((config.Default as ConfigAbility).Initialize());
                }
            }
            await Task.WhenAll(tasks);
            Logger.WriteLine("Finished Loading Resources");
        }
    }
}
