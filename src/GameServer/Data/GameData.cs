using System.Collections.Concurrent;
using System.Reflection;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using NLua;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp;
using Weedwacker.GameServer.Data.BinOut.AbilityGroup;
using Weedwacker.GameServer.Data.BinOut.AbilityPath;
using Weedwacker.GameServer.Data.BinOut.Avatar;
using Weedwacker.GameServer.Data.BinOut.Gadget;
using Weedwacker.GameServer.Data.BinOut.GadgetPath;
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
        public readonly static Dictionary<uint, AvatarCodexData> AvatarCodexDataMap = new(); // sortId
        public readonly static Dictionary<uint, AvatarCostumeData> AvatarCostumeDataMap = new(); // costumeId
        public readonly static Dictionary<uint, AvatarCurveData> AvatarCurveDataMap = new(); // level
        public readonly static Dictionary<uint, AvatarData> AvatarDataMap = new(); // AvatarId
        public readonly static Dictionary<uint, AvatarFetterLevelData> AvatarFetterLevelDataMap = new(); // level
        public readonly static Dictionary<uint, AvatarFlycloakData> AvatarFlycloakDataMap = new(); // flycloakId
        public readonly static Dictionary<uint, AvatarLevelData> AvatarLevelDataMap = new(); // Level
        public readonly static Dictionary<Tuple<uint, uint>, AvatarPromoteData> AvatarPromoteDataMap = new(); // <<PromoteId,promoteLevel>,Data>
        public readonly static Dictionary<uint, AvatarSkillData> AvatarSkillDataMap = new(); // SkillId
        public readonly static Dictionary<uint, AvatarSkillDepotData> AvatarSkillDepotDataMap = new(); // SkillDepotId
        public readonly static ConcurrentDictionary<string, Dictionary<string, BaseConfigTalent[]>> AvatarTalentConfigDataMap = new(); // file name
        public readonly static Dictionary<uint, AvatarTalentData> AvatarTalentDataMap = new(); // talentId
        public readonly static ConcurrentDictionary<string, ConfigAbilityContainer[]> ConfigAbilityAvatarMap = new(); // file name
        public readonly static Dictionary<uint, FetterCharacterCardData> FetterCharacterCardDataMap = new(); // avatarId
        public readonly static Dictionary<uint, FetterInfoData> FetterInfoDataMap = new(); // fetterId
        public readonly static Dictionary<uint, FettersData> FettersDataMap = new(); // fetterId
        public readonly static Dictionary<uint, FetterStoryData> FetterStoryDataMap = new(); // fetterId
        public readonly static Dictionary<uint, PhotographExpressionData> PhotographExpressionDataMap = new(); // fetterId
        public readonly static Dictionary<uint, PhotographPosenameData> PhotographPosenameDataMap = new(); // fetterId
        public readonly static Dictionary<uint, ProudSkillData> ProudSkillDataMap = new(); // proudSkillId
        //---------------------------------------------------------------------------------------------------------------------------------//
        public readonly static ConcurrentDictionary<string, AbilityGroupData> AbilityGroupDataMap = new(); // skillDepotAbilityGroup name
        public static AbilityPathData AbilityPathMap { get; private set; }

        public readonly static Dictionary<uint, AvatarHeroEntityData> AvatarHeroEntityDataMap = new();
        public readonly static ConcurrentDictionary<string, ConfigAbilityContainer[]> ConfigAbilityMap = new(); // file name
        public readonly static ConcurrentDictionary<string, ConfigAbilityContainer[]> ConfigAbilityActivityMap = new(); // file name
        public readonly static ConcurrentDictionary<string, ConfigAbilityContainer[]> ConfigAbilityAnimalMap = new(); // file name
        public readonly static ConcurrentDictionary<string, ConfigAbilityContainer[]> ConfigAbilityChallengeMap = new(); // file name
        public readonly static ConcurrentDictionary<string, ConfigAbilityContainer[]> ConfigAbilityEquipMap = new(); // file name
        public readonly static ConcurrentDictionary<string, ConfigAbilityContainer[]> ConfigAbilityGadgetMap = new(); // file name
        public readonly static ConcurrentDictionary<string, ConfigAbilityContainer[]> ConfigAbilityLevelMap = new(); // file name
        public readonly static ConcurrentDictionary<string, ConfigAbilityContainer[]> ConfigAbilityMonsterMap = new(); // file name
        public readonly static ConcurrentDictionary<string, ConfigAbilityContainer[]> ConfigAbilityMonsterAffixMap = new(); // file name
        public readonly static ConcurrentDictionary<string, ConfigAbilityContainer[]> ConfigAbilityQATestMap = new(); // file name
        public readonly static ConcurrentDictionary<string, ConfigAbilityContainer[]> ConfigAbilityQuestMap = new(); // file name
        public readonly static ConcurrentDictionary<string, ConfigAbilityContainer[]> ConfigAbilityTeamMap = new(); // file name
        public readonly static ConcurrentDictionary<string, ConfigAvatar> ConfigAvatarMap = new();
        public readonly static ConcurrentDictionary<string, ConfigGadget> ConfigGadgetMap = new();
        public readonly static Dictionary<uint, DungeonData> DungeonDataMap = new(); // id
        public readonly static Dictionary<uint, EnvAnimalGatherData> EnvAnimalGatherDataMap = new(); // animalId
        public readonly static Dictionary<uint, EquipAffixData> EquipAffixDataMap = new(); // affixId
        public readonly static Dictionary<Tuple<uint, uint>, GatherData> GatherDataMap = new(); // <id, gadgetId>
        public readonly static Dictionary<uint, GadgetData> GadgetDataMap = new(); // id
        public static GadgetPathData GadgetPathMap { get; private set; }
        public static GlobalCombatData GlobalCombatData { get; private set; }
        public readonly static Dictionary<uint, HomeWorldFurnitureData> HomeWorldFurnitureDataMap = new(); // id
        public readonly static Dictionary<uint, ItemData> ItemDataMap = new(); // id ItemData is subclassed, and loaded as MaterialData, ReliquaryData, and WeaponData
        public readonly static Dictionary<uint, MonsterCurveData> MonsterCurveDataMap = new(); // level
        public readonly static Dictionary<uint, MonsterData> MonsterDataMap = new(); // id
        public readonly static Dictionary<uint, MonsterDescribeData> MonsterDescribeDataMap = new(); // id
        public readonly static Dictionary<uint, OpenStateData> OpenStateDataMap = new(); // id
        public readonly static Dictionary<string, BaseConfigTalent[]> RelicAffixConfigDataMap = new(); // openConfig
        public readonly static Dictionary<uint, ShopData> ShopDataMap = new(); // shopId
        public readonly static Dictionary<uint, RewardData> RewardDataMap = new(); // RewardId
        public readonly static Dictionary<uint, ShopGoodsData> ShopGoodsDataMap = new(); // goodsId
        public readonly static ConcurrentDictionary<string, BaseConfigTalent[]> TeamResonanceConfigDataMap = new(); // openConfig
        public readonly static Dictionary<uint, ReliquaryAffixData> ReliquaryAffixDataMap = new(); // id
        public readonly static Dictionary<uint, ReliquaryMainPropData> ReliquaryMainPropDataMap = new(); // id
        public readonly static Dictionary<Tuple<uint, uint>, ReliquaryLevelData> ReliquaryLevelDataMap = new(); // <rank, level>
        public readonly static Dictionary<uint, ReliquarySetData> ReliquarySetDataMap = new(); // setid
        public readonly static Dictionary<uint, SceneData> SceneDataMap = new(); // id
        public readonly static ConcurrentDictionary<string, ScenePointData> ScenePointDataMap = new(); // filename
        public readonly static ConcurrentDictionary<uint, SceneNpcBornData> SceneNpcBornDataMap = new(); // sceneId
        public readonly static Dictionary<uint, SceneTagData> SceneTagDataMap = new(); // id
        public readonly static Dictionary<uint, TeamResonanceData> TeamResonanceDataMap = new(); // teamResonanceId 
        public readonly static ConcurrentDictionary<string, BaseConfigTalent[]> WeaponAffixConfigDataMap = new(); // openConfig
        public readonly static Dictionary<uint, WeaponCurveData> WeaponCurveDataMap = new(); // level
        public readonly static Dictionary<Tuple<uint, uint>, WeaponPromoteData> WeaponPromoteDataMap = new(); // <weaponPromoteId, promoteLevel>
        public readonly static Dictionary<uint, WeaponLevelData> WeaponLevelDataMap = new();  // level
        public readonly static Dictionary<uint, WeatherData> WeatherDataMap = new(); // areaId

        private readonly static Dictionary<uint, SceneInfo> SceneScripts = new();
        private static string ScriptPath;

        static readonly JsonSerializer Serializer = new()
        {
            // To handle $type
            TypeNameHandling = TypeNameHandling.Objects,
        };
        public static async Task<SceneInfo?> GetSceneScriptsAsync(uint sceneId)
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
                uint sceneId = uint.Parse(fullPath.Split(Path.DirectorySeparatorChar).Last());
                if (GameServer.Configuration.Server.DynamicLoadScenes && sceneId != 3) continue;
                tasks.Add(LoadSceneScripts(sceneId, path));
            }

            await Task.WhenAll(tasks);
        }

        static async Task LoadSceneScripts(uint sceneId, string scriptPath)
        {
            Lua lua = new();
            var SceneX = await SceneInfo.CreateAsync(lua, sceneId, scriptPath);
            SceneScripts.Add(sceneId, SceneX);
        }


        static async Task LoadBinOutFolder<Obj, Key>(string path, Func<Obj, Key> keySelector, IDictionary<Key, Obj> map) where Key : notnull
        {
            await Task.Yield();
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
            await Task.Yield();
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
                    try
                    {
                        var fileData = Serializer.Deserialize<Obj>(jr);
                        // Use the name (without ".json") of the file as the key
                        map.Add(Regex.Replace(filePath.Name, "\\.json", ""), fileData);
                    }
                    catch(Exception e)
                    {
                        Logger.DebugWriteLine(e.Message);
                    }
                }
            });
        }

        // To handle derived types
        static async Task LoadExcel<Obj, Key, DerivedType>(string path, Func<Obj, Key> keySelector, IDictionary<Key, Obj> map) where Key : notnull where DerivedType : Obj
        {
            var ra = typeof(DerivedType).GetResourceData();
            if (ra == null || !ra.GetResourceFile(path, out var fi)) return;
            var objs = await LoadObjects<DerivedType[]>(fi);
            if (objs == null) return;
            foreach (var obj in objs)
                map.Add(keySelector(obj), obj);
        }
        static async Task LoadExcel<Obj, Key>(string path, Func<Obj, Key> keySelector, IDictionary<Key, Obj> map) where Key : notnull
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
            var file = Path.Combine(path, ra.Name);
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

            string binout = "Weedwacker.GameServer.Data.BinOut";
            var q = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace != null && t.Namespace.StartsWith(binout));

            var arr = q.ToArray();
            var binder = new KnownTypesBinder() { KnownTypes = q };
            Serializer.SerializationBinder = binder;

            string file = Path.Combine(binPath, "Common", "ConfigGlobalCombat.json");
            FileInfo fi = new(file);
            using var sr = new StringReader(await File.ReadAllTextAsync(fi.FullName));
            using var jr = new JsonTextReader(sr);
            GlobalCombatData = Serializer.Deserialize<GlobalCombatData>(jr);

            string file2 = Path.Combine(binPath, "AbilityPath", "AbilityPathData.json");
            FileInfo fi2 = new(file2);
            using var sr2 = new StringReader(await File.ReadAllTextAsync(fi2.FullName));
            using var jr2 = new JsonTextReader(sr2);
            AbilityPathMap = Serializer.Deserialize<AbilityPathData>(jr2);

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
                LoadExcel<ItemData, uint, MaterialData>(excelPath, o => o.id, ItemDataMap),
                LoadExcel(excelPath, o => o.level, MonsterCurveDataMap),
                LoadExcel(excelPath, o => o.id, MonsterDataMap),
                LoadExcel(excelPath, o => o.id, MonsterDescribeDataMap),
                LoadExcel(excelPath, o => o.id, OpenStateDataMap),
                LoadExcel(excelPath, o => o.fetterId, PhotographExpressionDataMap),
                LoadExcel(excelPath, o => o.fetterId, PhotographPosenameDataMap),
                LoadExcel(excelPath, o => o.proudSkillId, ProudSkillDataMap),
                LoadExcel<ItemData, uint, ReliquaryData>(excelPath, o => o.id, ItemDataMap),
                LoadExcel(excelPath, o => o.id, ReliquaryAffixDataMap),
                LoadExcel(excelPath, o => o.id, ReliquaryMainPropDataMap),
                LoadExcel(excelPath, o => Tuple.Create(o.rank, o.level), ReliquaryLevelDataMap),
                LoadExcel(excelPath, o => o.level, WeaponLevelDataMap),
                LoadExcel(excelPath, o => o.setId, ReliquarySetDataMap),
                LoadExcel(excelPath, o => o.rewardId, RewardDataMap),
                LoadExcel(excelPath, o => o.id, SceneDataMap),
                LoadExcel(excelPath, o => o.id, SceneTagDataMap),
                LoadExcel(excelPath, o => o.shopId, ShopDataMap),
                LoadExcel(excelPath, o=> o.goodsId, ShopGoodsDataMap),
                LoadExcel(excelPath, o => o.teamResonanceId, TeamResonanceDataMap),
                LoadExcel<ItemData, uint, WeaponData>(excelPath, o => o.id, ItemDataMap),
                LoadExcel(excelPath, o => o.level, WeaponCurveDataMap),
                LoadExcel(excelPath, o => Tuple.Create(o.weaponPromoteId, o.promoteLevel), WeaponPromoteDataMap),
                LoadExcel(excelPath, o => o.areaId, WeatherDataMap),

                LoadBinOutFolder(Path.Combine(binPath, "Ability", "Temp"), ConfigAbilityMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Ability", "Temp", "ActivityAbilities"), ConfigAbilityActivityMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Ability", "Temp", "AnimalAbilities"), ConfigAbilityAnimalMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Ability", "Temp", "AvatarAbilities"), ConfigAbilityAvatarMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Ability", "Temp", "ChallengeAbilities"), ConfigAbilityChallengeMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Ability", "Temp", "EquipAbilities"), ConfigAbilityEquipMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Ability", "Temp", "GadgetAbilities"), ConfigAbilityGadgetMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Ability", "Temp", "LevelAbilities"), ConfigAbilityLevelMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Ability", "Temp", "MonsterAbilities"), ConfigAbilityMonsterMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Ability", "Temp", "MonsterAffixAbilities"), ConfigAbilityMonsterAffixMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Ability", "Temp", "QATestAbilities"), ConfigAbilityQATestMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Ability", "Temp", "QuestAbilities"), ConfigAbilityQuestMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Ability", "Temp", "TeamAbilities"), ConfigAbilityTeamMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Scene", "SceneNpcBorn"), o => o.sceneId,  SceneNpcBornDataMap),
                LoadBinOutFolder(Path.Combine(binPath, "AbilityGroup"), AbilityGroupDataMap),
                LoadBinOutFolder(Path.Combine(binPath, "Talent", "AvatarTalents"), AvatarTalentConfigDataMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Avatar"), ConfigAvatarMap, false),
                LoadBinOutFolder(Path.Combine(binPath, "Gadget"), ConfigGadgetMap, true),
                LoadBinOutFolder(Path.Combine(binPath, "Talent", "EquipTalents"), WeaponAffixConfigDataMap),
                LoadBinOutFolder(Path.Combine(binPath, "Talent", "RelicTalents"), RelicAffixConfigDataMap),
                LoadBinOutFolder(Path.Combine(binPath, "Talent", "TeamTalents"), TeamResonanceConfigDataMap),
                LoadBinOutFolder(Path.Combine(binPath, "Scene", "Point"), ScenePointDataMap, false),

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
