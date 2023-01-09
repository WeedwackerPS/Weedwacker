using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp;
using Weedwacker.GameServer.Data.BinOut.Talent;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Avatar
{
    internal class SkillDepot
    {
        [BsonElement] public uint DepotId { get; private set; }
        [BsonIgnore] private Player.Player Owner; // Loaded by DatabaseManager
        [BsonIgnore] private Avatar Character; // Loaded by DatabaseManager
        [BsonElement] public uint EnergySkill { get; private set; } // Ultimate elemental ability (Q)
        [BsonElement] public uint EnergySkillLevel { get; private set; }
        [BsonElement] public ElementType? Element { get; private set; } // Stores current and max energy
        [BsonIgnore] public Dictionary<uint, ConfigAbility>? Abilities { get; private set; } // hash
        [BsonElement] public SortedList<uint, uint> Skills { get; private set; } = new(); // <skillId,level>
        [BsonElement] public SortedList<uint, uint> SubSkills { get; private set; } = new(); // <skillId,level>
        [BsonElement] public SortedList<uint, uint> SkillExtraChargeMap { get; private set; } = new(); // Charges
        [BsonElement] public HashSet<ProudSkillData> InherentProudSkillOpens { get; private set; } = new();
        [BsonIgnore] public IEnumerable<ProudSkillData> TeamOpens => InherentProudSkillOpens.Where(w => w.effectiveForTeam == 1);
        [BsonElement] public HashSet<uint> Talents { get; private set; } = new(); // talentId. last digit of id = constellationRank.
        [BsonIgnore] public Dictionary<string, HashSet<string>> UnlockedTalentParams = new(); // <abilityName, talentParams> Added by ConfigTalent UnlockTalentParam
        [BsonIgnore] public HashSet<string> ActiveDynamicAbilities { get; private set; } = new(); // abilityName
        [BsonIgnore] public Dictionary<uint, Dictionary<uint, float>?>? AbilitySpecials { get; private set; } = new(); // <abilityNameHash, <abilitySpecialHash, value>> Variables used in ConfigAbility_<Avatar>.json
        [BsonIgnore] public SortedList<uint, uint> ProudSkillExtraLevelMap { get; private set; } = new(); // <groupId,extraLevels> 

        public SkillDepot(Avatar avatar, uint depotId, Player.Player owner)
        {
            Owner = owner;
            Character = avatar;
            DepotId = depotId;
            var avatarInfo = GameServer.AvatarInfo[avatar.AvatarId];
            EnergySkill = avatarInfo.SkillDepotData[depotId].energySkill;
            // Hero Avatars don't have an element at the beginning
            if (EnergySkill != 0)
            {
                EnergySkillLevel = 1;
                Enums.ElementType type = avatarInfo.SkillData[depotId][EnergySkill].costElemType;
                switch (type)
                {
                    case Enums.ElementType.Fire:
                        Element = new Fire();
                        break;
                    case Enums.ElementType.Water:
                        Element = new Water();
                        break;
                    case Enums.ElementType.Wind:
                        Element = new Wind();
                        break;
                    case Enums.ElementType.Ice:
                        Element = new Ice();
                        break;
                    case Enums.ElementType.Rock:
                        Element = new Rock();
                        break;
                    case Enums.ElementType.Electric:
                        Element = new Electric();
                        break;
                    case Enums.ElementType.Grass:
                        Element = new Grass();
                        break;
                    default:
                        Logger.WriteErrorLine("Unknown Avatar Element Type");
                        break;
                }
                Element.MaxEnergy = avatarInfo.SkillData[depotId][EnergySkill].costElemVal;
            }

            foreach (uint skillId in avatarInfo.SkillDepotData[depotId].skills)
            {
                if (skillId != 0) Skills.Add(skillId, 1);
            }

            var inherentProudSkillGroups = avatarInfo.SkillDepotData[depotId].inherentProudSkillOpens.Where(w => w.needAvatarPromoteLevel <= 1).ToDictionary(q => q.proudSkillGroupId).Keys.ToList();
            foreach (int group in inherentProudSkillGroups)
            {
                var idList = avatarInfo.ProudSkillData[depotId].Where(w => w.Value.proudSkillGroupId == group).ToDictionary(q => q.Key).Keys.ToList();
                foreach (uint id in idList)
                {
                    InherentProudSkillOpens.Add(avatarInfo.ProudSkillData[depotId][id]);
                }
            }

            InitializeConfig();
        }

        private void InitializeConfig()
        {
            Abilities = new();
            AbilitySpecials = new();
            ProudSkillExtraLevelMap = new();
            foreach (var configAbility in Character.Data.AbilityConfigMap[DepotId])
            {
                ConfigAbility config = configAbility.Default;
                AbilitySpecials.Add(Utils.AbilityHash(config.abilityName), config.abilitySpecials.ToDictionary( w => Utils.AbilityHash(w.Key), w => w.Value));
            }
            if (Character.Data.AbilityHashMap.TryGetValue(DepotId, out Dictionary<uint, ConfigAbility>? hashMap))
                Abilities = hashMap;

            foreach (ConfigAbilityContainer container in GameData.ConfigAbilityAvatarMap["ConfigAbility_Avatar_AllDefault"])
            {
                ConfigAbility config = container.Default;
                Abilities[Utils.AbilityHash(config.abilityName)] = config;
            }
            foreach (string abilityName in GameData.GlobalCombatData.defaultAbilities.defaultAvatarAbilities)
            {
                foreach (ConfigAbilityContainer container in GameData.ConfigAbilityAvatarMap["ConfigAbility_Avatar_Common"])
                {
                    ConfigAbility config = container.Default;
                    if (config.abilityName == abilityName)
                    {
                        Abilities[Utils.AbilityHash(config.abilityName)] = config;
                    }
                }
            }

        }

        public async Task OnLoadAsync(Player.Player owner, Avatar avatar)
        {
            Owner = owner;
            Character = avatar;
            InitializeConfig();
        }
        public uint GetCoreProudSkillLevel()
        {
            return (uint)Talents.Count;
        }

        public List<uint> GetSkillsAndEnergySkill()
        {
            var list = Skills.Values.Where(w => w > 0).ToList();
            list.Add(EnergySkill);
            return list;

        }
        public Dictionary<uint, uint> GetSkillLevelMap()
        {
            Dictionary<uint, uint> skillz = new()
            {
                { EnergySkill, EnergySkillLevel }
            };
            foreach (uint skill in Skills.Keys)
            {
                skillz.Add(skill, Skills[skill]);
            }

            return skillz;
        }

        public async Task<bool> UpgradeSkill(uint skillId)
        {
            AvatarSkillData skillData = GameServer.AvatarInfo[Character.AvatarId].SkillData[DepotId][skillId];
            if (skillData == null) return false;

            // Get data for next skill level
            uint newLevel = Skills.GetValueOrDefault<uint, uint>(skillId, 0) + 1;
            if (newLevel > 10) return false;

            // Proud skill data
            ProudSkillData proudSkill = GameServer.AvatarInfo[Character.AvatarId].ProudSkillData[DepotId]
                .Where(w => w.Value.proudSkillGroupId == skillData.proudSkillGroupId && w.Value.level == newLevel).First().Value;

            // Make sure break level is correct
            if (Character.PromoteLevel < proudSkill.breakLevel) return false;

            // Pay materials and mora if possible
            if (!await Owner.Inventory.PayPromoteCostAsync(proudSkill.GetTotalCostItems())) return false;

            // Upgrade skill        
            return await SetSkillLevel(skillId, newLevel);
        }

        internal async Task SendAvatarSkillInfoNotify()
        {
            if (!SkillExtraChargeMap.Any()) return;
            await Owner.SendPacketAsync(new PacketAvatarSkillInfoNotify(Character.Guid, SkillExtraChargeMap));
        }

        public async Task<bool> SetSkillLevel(uint skillId, uint level)
        {
            if (level < 0 || level > 15) return false;
            uint oldLevel = Skills.GetValueOrDefault<uint, uint>(skillId, 0);
            Skills[skillId] = level;

            // Update Database
            var filter = Builders<AvatarManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var update = Builders<AvatarManager>.Update.Set(w => w.Avatars[Character.AvatarId].SkillDepots[DepotId].Skills[skillId], level);
            await DatabaseManager.UpdateAvatarsAsync(filter, update);

            // Packet
            await Owner.SendPacketAsync(new PacketAvatarSkillChangeNotify(Character, DepotId, skillId, oldLevel, level));

            return true;
        }
        private void AddTalent(uint talentId)
        {
            var talentData = Character.Data.TalentData[DepotId][talentId];
            Talents.Add(talentData.talentId);
            foreach (BaseConfigTalent config in Character.Data.ConfigTalentMap[DepotId][talentData.openConfig])
            {
                config.Apply(Character.AsEntity.AbilityManager, talentData.paramList);
            }
        }
        public async Task<bool> UnlockConstellation(uint talentId, bool skipPayment = false)
        {
            // Get talent
            AvatarTalentData talentData = GameServer.AvatarInfo[Character.AvatarId].TalentData[DepotId][talentId];
            if (talentData == null) return false;

            // Pay constellation item if possible
            if (!skipPayment && !await Owner.Inventory.PayPromoteCostAsync(new ItemParamData[] { new ItemParamData(talentData.mainCostItemId, 1) })) // don't judge...
            {
                return false;
            }

            // Apply + recalc
            AddTalent(talentId);

            // Update Database
            var filter = Builders<AvatarManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var update = Builders<AvatarManager>.Update.Set(w => w.Avatars[Character.AvatarId].SkillDepots[DepotId], this);
            await DatabaseManager.UpdateAvatarsAsync(filter, update);

            // Packet
            await Owner.SendPacketAsync(new PacketAvatarUnlockTalentNotify(Character, DepotId, talentId));

            // Recalc + update avatar
            await Character.RecalcStatsAsync(true);

            return true;
        }
    }
}
