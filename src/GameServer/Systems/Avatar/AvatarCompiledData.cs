using System.Diagnostics;
using System.Text.RegularExpressions;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp;
using Weedwacker.GameServer.Data.BinOut.AbilityGroup;
using Weedwacker.GameServer.Data.BinOut.Avatar;
using Weedwacker.GameServer.Data.BinOut.Talent;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Avatar
{
    // ONLY ONE INSTANCE PER AVATAR ID
    internal class AvatarCompiledData
    {
        public readonly int AvatarId;
        public string AvatarName => GeneralData.iconName.Split("_").Last();
        public AvatarData GeneralData => GameData.AvatarDataMap[AvatarId];
        public ConfigAvatar ConfigAvatar => GameData.ConfigAvatarMap[$"ConfigAvatar_{AvatarName}"];
        public readonly SortedList<int, AvatarSkillDepotData> SkillDepotData; // <depotId,depot> Skill, SubSkill, Talent, and ProudSkill ids. So far only the twins have multiple. Assume first is default
        public readonly SortedList<int, SortedList<int, AvatarSkillData>> SkillData; // <depotId,<skillId,data>>
        public SortedList<int, AvatarPromoteData> PromoteData => new(GameData.AvatarPromoteDataMap.Where(w => w.Key.Item1 == GeneralData.avatarPromoteId).ToDictionary(x => x.Key.Item2, x => x.Value)); // <promoteLevel,data> AKA Ascension
        public readonly SortedList<int, SortedList<int, AvatarTalentData>> TalentData; // <depotId,<talentId,data>> Constellations and skill upgrades
        public readonly SortedList<int, SortedList<int, ProudSkillData>> ProudSkillData; // <depotId,<proudSkillId,data>> Passives
        public readonly SortedList<int, Dictionary<uint, ConfigAbility>?> AbilityHashMap; //<depotId,<Hashes, config>>
        public SortedList<int, AvatarCostumeData> CostumeData => new(GameData.AvatarCostumeDataMap.Where(w => w.Value.avatarId == AvatarId).ToDictionary(x => x.Key, x => x.Value)); // costumeId
        public SortedList<int, AvatarCodexData> CodexData => new(GameData.AvatarCodexDataMap.Where(w => w.Value.avatarId == AvatarId).ToDictionary(x => x.Key, x => x.Value)); // sortId Codex entry
        public static SortedList<int, AvatarLevelData> LevelData => GameData.AvatarLevelDataMap; // <level,exp> Level exp breakpoints
        public static SortedList<int, AvatarCurveData> CurveData => GameData.AvatarCurveDataMap; // <level,curveInfo> Base Stat multipliers
        public static SortedList<int, AvatarFlycloakData> FlycloakData => GameData.AvatarFlycloakDataMap; // flycloakId
        public readonly SortedList<int, ConfigAbilityContainer[]> AbilityConfigMap = new(); // depotId
        public readonly SortedList<int, Dictionary<string, BaseConfigTalent[]>> ConfigTalentMap = new(); // <depotId, file name>


        // Fetters
        public FetterCharacterCardData CardData => GameData.FetterCharacterCardDataMap.GetValueOrDefault(AvatarId);
        public FetterInfoData FetterInfoData => GameData.FetterInfoDataMap.Where(w => w.Value.avatarId == AvatarId).FirstOrDefault().Value; // General info
        public SortedList<int, FetterStoryData> FetterStoryData => new(GameData.FetterStoryDataMap.Where(w => w.Value.avatarId == AvatarId).ToDictionary(w => w.Key, w => w.Value)); // fetterId
        public SortedList<int, FettersData> FettersData => new(GameData.FettersDataMap.Where(w => w.Value.avatarId == AvatarId).ToDictionary(w => w.Key, w => w.Value)); // fetterId
        public SortedList<int, PhotographPosenameData> PhotographPosenameData => new(GameData.PhotographPosenameDataMap.Where(w => w.Value.avatarId == AvatarId).ToDictionary(w => w.Key, w => w.Value)); // fetterId
        public SortedList<int, PhotographExpressionData> PhotographExpressionData => new(GameData.PhotographExpressionDataMap.Where(w => w.Value.avatarId == AvatarId).ToDictionary(w => w.Key, w => w.Value)); // fetterId
        public static SortedList<int, AvatarFetterLevelData> FetterLevelData => GameData.AvatarFetterLevelDataMap; // level Friendship exp breakpoints

        public readonly Tuple<ArithType, float>[] HpGrowthCurve;
        public readonly Tuple<ArithType, float>[] AttackGrowthCurve;
        public readonly Tuple<ArithType, float>[] DefenseGrowthCurve;



        public readonly List<int> Fetters;
        public readonly int NameCardRewardId;
        public readonly int NameCardId;
        public AvatarCompiledData(int avatarId)
        {
            AvatarId = avatarId;
            if (avatarId== 10000075)
            {
                Debugger.Break();
            }
            if (GeneralData.candSkillDepotIds.Count() != 0)
            {
                SkillDepotData = new();
                foreach (int depotId in GeneralData.candSkillDepotIds)
                {
                    SkillDepotData.Add(depotId, GameData.AvatarSkillDepotDataMap[depotId]);
                }
            }
            else
            {
                SkillDepotData = new() { { GeneralData.skillDepotId, GameData.AvatarSkillDepotDataMap[GeneralData.skillDepotId] } };
            }
            SkillData = new();
            TalentData = new();
            ProudSkillData = new();
            AbilityHashMap = new();
            foreach (AvatarSkillDepotData depot in SkillDepotData.Values)
            {
                string name;
                if (depot.skillDepotAbilityGroup != null && depot.skillDepotAbilityGroup != "")
                {
                    // Get the ConfigAbility name used. twins have 1 ConfigAbility and ConfigTalent per element
                    name = Regex.Replace(depot.skillDepotAbilityGroup, "AbilityGroup_Girl_", "");
                    name = Regex.Replace(name, "AbilityGroup_Boy_", "");
                }
                else
                {
                    name = $"Avatar_{AvatarName}";
                }
                if (!GameData.ConfigAbilityAvatarMap.TryGetValue($"ConfigAbility_{name}", out ConfigAbilityContainer[]? configContainer))
                {
                    continue;
                }
                AbilityConfigMap.Add(depot.id, configContainer);
                var dictionary1 = GameData.AvatarSkillDataMap.Where(w => depot.skills.Contains(w.Key) || depot.subSkills.Contains(w.Key) || depot.energySkill == w.Key).ToDictionary(x => x.Key, x => x.Value);
                SkillData.Add(depot.id, new SortedList<int, AvatarSkillData>(dictionary1));
                var dictionary7 = GameData.AvatarTalentDataMap.Where(w => depot.talents.Contains(w.Value.talentId)).ToDictionary(x => x.Key, x => x.Value);
                TalentData.Add(depot.id, new SortedList<int, AvatarTalentData>(dictionary7));
                var dictionary8 = GameData.ProudSkillDataMap.Where(w => depot.inherentProudSkillOpens.Exists(y => y.proudSkillGroupId == w.Value.proudSkillGroupId)).ToDictionary(x => x.Key, x => x.Value);
                ProudSkillData.Add(depot.id, new SortedList<int, ProudSkillData>(dictionary8));
                foreach (var skilldata in dictionary1.Values)
                {
                    var proudData = GameData.ProudSkillDataMap.Where(w => w.Value.proudSkillGroupId == skilldata.proudSkillGroupId);
                    foreach (var proud in proudData)
                    {
                        ProudSkillData[depot.id][proud.Key] = proud.Value;
                    }
                }
                if (GameData.AvatarTalentConfigDataMap.TryGetValue($"ConfigTalent_{Regex.Replace(name, "Avatar_", "")}", out Dictionary<string, BaseConfigTalent[]>? configTalents))
                    ConfigTalentMap[depot.id] = configTalents;
                Dictionary<uint, ConfigAbility> abilityHashMap = new();
                // add abilityGroup abilities (if player skill depot ability group)
                if (depot.skillDepotAbilityGroup != null && depot.skillDepotAbilityGroup.Length > 0)
                {
                    AbilityGroupData? abilityData = GameData.AbilityGroupDataMap.GetValueOrDefault(depot.skillDepotAbilityGroup);

                    if (abilityData != null)
                    {
                        foreach (TargetAbility ability in abilityData.targetAbilities.Concat(ConfigAvatar.abilities))
                        {
                            ConfigAbility? config = null;
                            foreach (var container in AbilityConfigMap[depot.id])
                            {
                                if (container.Default is ConfigAbility konfig && konfig.abilityName == ability.abilityName)
                                {
                                    config = konfig;
                                    break;
                                }
                            }
                            if (config == null) continue;
                            abilityHashMap[(uint)Utils.AbilityHash(ability.abilityName)] = config;
                        }
                    }
                }
                foreach (TargetAbility ability in GameData.ConfigAvatarMap[$"ConfigAvatar_{AvatarName}"].abilities)
                {
                    ConfigAbility? config = null;
                    foreach (var container in AbilityConfigMap[depot.id])
                    {
                        if (container.Default is ConfigAbility konfig && konfig.abilityName == ability.abilityName)
                        {
                            config = konfig;
                            break;
                        }
                    }
                    if (config == null) continue;
                    abilityHashMap[(uint)Utils.AbilityHash(ability.abilityName)] = config;
                }
                AbilityHashMap.Add(depot.id, abilityHashMap);
            }

            HpGrowthCurve = new Tuple<ArithType, float>[CurveData.Count];
            AttackGrowthCurve = new Tuple<ArithType, float>[CurveData.Count];
            DefenseGrowthCurve = new Tuple<ArithType, float>[CurveData.Count];
            foreach (AvatarCurveData curveData in CurveData.Values)
            {
                int level = curveData.level - 1;
                foreach (PropGrowCurve growCurve in GeneralData.propGrowCurves)
                {
                    switch (growCurve.type)
                    {
                        case FightProperty.FIGHT_PROP_BASE_HP:
                            HpGrowthCurve[level] = curveData.GetArith(growCurve.growCurve);
                            break;
                        case FightProperty.FIGHT_PROP_BASE_ATTACK:
                            AttackGrowthCurve[level] = curveData.GetArith(growCurve.growCurve);
                            break;
                        case FightProperty.FIGHT_PROP_BASE_DEFENSE:
                            DefenseGrowthCurve[level] = curveData.GetArith(growCurve.growCurve);
                            break;
                        default:
                            Logger.WriteErrorLine("Error loading Avatar Growth Curves");
                            break;
                    }
                }
            }
        }

        private static float CalcValue(float value, Tuple<ArithType, float> curve)
        {
            switch (curve.Item1)
            {
                case ArithType.ARITH_MULTI:
                    return value * curve.Item2;
                case ArithType.ARITH_ADD:
                    return value + curve.Item2;
                default:
                    Logger.WriteErrorLine($"Unhandled Avatar curve operation {curve.Item1}");
                    goto case ArithType.ARITH_MULTI;
            }
        }
        public float GetBaseHp(int level)
        {
            try
            {
                return CalcValue(GeneralData.hpBase, HpGrowthCurve[level - 1]);
            }
            catch (Exception e)
            {
                return GeneralData.hpBase;
            }
        }

        public float GetBaseAttack(int level)
        {
            try
            {
                return CalcValue(GeneralData.attackBase, AttackGrowthCurve[level - 1]);
            }
            catch (Exception e)
            {
                return GeneralData.attackBase;
            }
        }

        public float GetBaseDefense(int level)
        {
            try
            {
                return CalcValue(GeneralData.defenseBase, DefenseGrowthCurve[level - 1]);
            }
            catch (Exception e)
            {
                return GeneralData.defenseBase;
            }
        }

        public float GetBaseCritical()
        {
            return GeneralData.critical;
        }

        public float GetBaseCriticalHurt()
        {
            return GeneralData.criticalHurt;
        }

    }
}
