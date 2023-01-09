using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.Inventory;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;
using static Weedwacker.GameServer.Data.Excel.WeaponData;

namespace Weedwacker.GameServer.Systems.Avatar
{
    internal class Avatar
    {
        [BsonElement] public int BornTime { get; private set; }
        [BsonElement] public uint AvatarId { get; private set; }           // Id of avatar
        [BsonIgnore] public Player.Player Owner { get; private set; } // Loaded by DatabaseManager
        [BsonIgnore] public AvatarCompiledData Data => GameServer.AvatarInfo[AvatarId];
        [BsonIgnore] public ulong Guid { get; private set; }           // Player unique Avatar id. Generated each session
        [BsonIgnore] public uint EntityId => AsEntity.EntityId;

        [BsonElement] public uint Level { get; private set; } = 1;
        public int Exp;
        [BsonElement] public uint PromoteLevel { get; private set; } = 0;
        public int Satiation; // ?
        public int SatiationPenalty; // ?
        [BsonElement] public LifeState LifeState { get; private set; } = LifeState.LIFE_ALIVE;
        public HashSet<string> EquipOpenConfigs; // openConfigs from relics and weapon TODO
        [BsonElement] public uint CurrentDepotId { get; private set; }
        [BsonSerializer(typeof(UIntDictionarySerializer<SkillDepot>))]
        [BsonElement] public Dictionary<uint, SkillDepot> SkillDepots { get; private set; } = new();
        [BsonIgnore] public SkillDepot CurSkillDepot => SkillDepots[CurrentDepotId];

        [BsonElement] public FetterSystem Fetters { get; private set; }
        [BsonIgnore] public Dictionary<EquipType, EquipItem> Equips { get; private set; } = new(); // Loaded through the inventory system
        [BsonIgnore] public WeaponItem? Weapon => (WeaponItem?)Equips.GetValueOrDefault(EquipType.EQUIP_WEAPON);
        [BsonElement] public Dictionary<FightProperty, float> FightProp { get; private set; } = new();
        [BsonElement] public HashSet<string> AppliedOpenConfigs { get; private set; } = new();

        [BsonElement] public uint FlyCloak { get; set; } = 140001;
        [BsonElement] public uint Costume { get; private set; } = default; // no costume

        [BsonIgnore] public AvatarEntity AsEntity;

        public static Task<Avatar> CreateAsync(uint avatarId, Player.Player owner)
        {
            var ret = new Avatar();
            return ret.InitializeAsync(avatarId, owner);
        }
        private async Task<Avatar> InitializeAsync(uint avatarId, Player.Player owner)
        {
            AvatarId = avatarId;
            Guid = owner.GetNextGameGuid();

            if (Data.GeneralData.candSkillDepotIds.Length > 0)
            {
                foreach (uint depotId in Data.AbilityConfigMap.Keys)
                {
                    SkillDepots.Add(depotId, new SkillDepot(this, depotId, owner));
                }
            }
            else
            {
                SkillDepots.Add(Data.GeneralData.skillDepotId, new SkillDepot(this, Data.GeneralData.skillDepotId, owner));
            }
            CurrentDepotId = Data.GeneralData.skillDepotId;
            Fetters = await FetterSystem.CreateAsync(this, owner);
            Owner = owner;
            BornTime = (int)(DateTimeOffset.Now.ToUnixTimeMilliseconds() / 1000);

            // Combat properties
            foreach (FightProperty property in (FightProperty[])Enum.GetValues(typeof(FightProperty)))
            {
                if ((int)property > 0 && (int)property < 3000) FightProp.Add(property, 0f);
            }

            // Set stats
            await RecalcStatsAsync();
            await SetCurrentHp(FightProp[FightProperty.FIGHT_PROP_MAX_HP]);

            var weapon = Owner.Inventory.AddItemByIdAsync(Data.GeneralData.initialWeapon).Result;
            await EquipWeapon((WeaponItem)weapon, false);

            return this;
        }

        internal Avatar Clone()
        {
            throw new NotImplementedException();
        }

        public async Task OnLoadAsync(Player.Player owner)
        {
            Owner = owner;
            Guid = owner.GetNextGameGuid();
            var tasks = new List<Task>
            {
                Fetters.OnLoadAsync(owner, this)
            };
            foreach (SkillDepot depot in SkillDepots.Values)
            {
                tasks.Add(depot.OnLoadAsync(owner, this));
            }
            await Task.WhenAll(tasks);
        }
        public async Task<bool> SetCurrentHp(float value, bool notifyClient = true)
        {
            if (FightProp.GetValueOrDefault(FightProperty.FIGHT_PROP_MAX_HP) <= value) return false;
            FightProp[FightProperty.FIGHT_PROP_CUR_HP] = value;
            // Update
            var filter = Builders<AvatarManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var update = Builders<AvatarManager>.Update.Set($"{nameof(AvatarManager.Avatars)}.{AvatarId}.{nameof(FightProp)}.{FightProperty.FIGHT_PROP_CUR_HP}", value);
            await DatabaseManager.UpdateAvatarsAsync(filter, update);
            if (notifyClient) await Owner.SendPacketAsync(new PacketAvatarFightPropUpdateNotify(this, FightProperty.FIGHT_PROP_CUR_HP));
            return true;
        }
        public async Task<bool> SetFlyCloakAsync(uint cloakId)
        {
            FlyCloak = cloakId;
            var filter = Builders<AvatarManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var update = Builders<AvatarManager>.Update.Set($"{nameof(AvatarManager.Avatars)}.{AvatarId}.{FlyCloak}", FlyCloak);
            await DatabaseManager.UpdateAvatarsAsync(filter, update);
            await Owner.SendPacketAsync(new PacketAvatarFlycloakChangeNotify(this));

            return true;
        }

        static public int GetMinPromoteLevel(int level)
        {
            if (level > 80)
            {
                return 6;
            }
            else if (level > 70)
            {
                return 5;
            }
            else if (level > 60)
            {
                return 4;
            }
            else if (level > 50)
            {
                return 3;
            }
            else if (level > 40)
            {
                return 2;
            }
            else if (level > 20)
            {
                return 1;
            }
            return 0;
        }

        public GameItem? GetRelic(EquipType slot)
        {
            if (slot == EquipType.EQUIP_WEAPON)
            {
                Logger.WriteErrorLine("Tried to access weapon as relic");
                return null;
            }
            return Equips[slot];
        }

        public float GetCurrentEnergy()
        {
            if (CurSkillDepot.Element != null)
                return CurSkillDepot.Element.CurEnergy;
            else
                return 0;
        }
        public async Task<bool> SetCurrentEnergy(float currentEnergy, bool update = true)
        {
            if (CurSkillDepot.Element != null)
            {
                CurSkillDepot.Element.CurEnergy = currentEnergy;
                FightProp[CurSkillDepot.Element.CurEnergyProp] = currentEnergy;

                // false = used in RecalcStatsAsync or is in Tower team
                if (update)
                {
                    // Update
                    var filter = Builders<AvatarManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var updateQuery = Builders<AvatarManager>.Update.Set($"{nameof(AvatarManager.Avatars)}.{AvatarId}.{CurSkillDepot.Element.CurEnergyProp}", currentEnergy);
                    await DatabaseManager.UpdateAvatarsAsync(filter, updateQuery);

                    await Owner.SendPacketAsync(new PacketAvatarFightPropUpdateNotify(this, CurSkillDepot.Element.CurEnergyProp));
                }
                return true;
            }
            else
                return false;
        }

        public async Task<bool> AddToFightProperty(FightProperty prop, float value, bool update = true)
        {
            FightProp[prop] = FightProp.GetValueOrDefault(prop) + value;

            // false = used in RecalcStatsAsync
            if (update)
            {
                // Update
                var filter = Builders<AvatarManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                var updateQuery = Builders<AvatarManager>.Update.Set($"{nameof(AvatarManager.Avatars)}.{AvatarId}.{nameof(FightProp)}.{prop}", FlyCloak);
                await DatabaseManager.UpdateAvatarsAsync(filter, updateQuery);
                await Owner.SendPacketAsync(new PacketAvatarFightPropUpdateNotify(this, prop));
                return true;
            }
            return true;
        }

        public async Task<bool> EquipRelic(ReliquaryItem item, bool notifyClient = true)
        {
            // Sanity check equip type
            EquipType itemEquipType = item.ItemData.equipType;
            if (itemEquipType == EquipType.EQUIP_NONE)
            {
                return false;
            }

            else if (GetRelic(itemEquipType) != null)
            {
                // Unequip item in current slot if it exists
                await UnequipRelic(itemEquipType);
            }

            // Set equip
            Equips[itemEquipType] = item;
            item.EquippedAvatar = AvatarId;

            //TODO add relic openConfigs

            // Update Database
            var inventoryFilter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var inventoryUpdate = Builders<InventoryManager>.Update.Set($"{nameof(InventoryManager.SubInventories)}.{ItemType.ITEM_RELIQUARY}.{nameof(RelicTab.Items)}.{item.Id}.{nameof(EquipItem.EquippedAvatar)}", item.EquippedAvatar);
            await DatabaseManager.UpdateInventoryAsync(inventoryFilter, inventoryUpdate);

            if (Owner.HasSentLoginPackets)
            {
                await Owner.SendPacketAsync(new PacketAvatarEquipChangeNotify(this, item, itemEquipType));
            }

            await RecalcStatsAsync(notifyClient);

            return true;
        }
        public async Task<bool> EquipWeapon(WeaponItem item, bool notifyClient = true)
        {
            if (Weapon != null)
            {
                // Unequip item in current slot if it exists
                await UnequipWeapon(notifyClient);
            }

            // Set equip
            Equips[EquipType.EQUIP_WEAPON] = item;
            item.EquippedAvatar = AvatarId;
            if (Owner.World != null)
                item.WeaponEntityId = Owner.World.GetNextEntityId(EntityIdType.WEAPON);

            //TODO apply weapon openConfigs

            // Update Database
            var inventoryFilter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var inventoryUpdate = Builders<InventoryManager>.Update.Set($"{nameof(InventoryManager.SubInventories)}.{ItemType.ITEM_WEAPON}.{nameof(WeaponTab.Items)}.{item.Id}.{nameof(WeaponItem.EquippedAvatar)}", item.EquippedAvatar);
            await DatabaseManager.UpdateInventoryAsync(inventoryFilter, inventoryUpdate);

            if (Owner.HasSentLoginPackets && notifyClient)
            {
                await Owner.SendPacketAsync(new PacketAvatarEquipChangeNotify(this, item, EquipType.EQUIP_WEAPON));
            }

            await RecalcStatsAsync(notifyClient);

            return true;
        }

        public async Task<bool> UnequipRelic(EquipType slot, bool notifyClient = true)
        {
            ReliquaryItem item = (ReliquaryItem)Equips[slot];
            Equips.Remove(slot);

            //TODO remove relic openConfigs


            if (item != null)
            {
                item.EquippedAvatar = 0;

                // Update Database
                var inventoryFilter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                var inventoryUpdate = Builders<InventoryManager>.Update.Set($"{nameof(InventoryManager.SubInventories)}.{ItemType.ITEM_RELIQUARY}.{nameof(RelicTab.Items)}.{item.Id}.{nameof(ReliquaryItem.EquippedAvatar)}", item.EquippedAvatar);
                await DatabaseManager.UpdateInventoryAsync(inventoryFilter, inventoryUpdate);

                await Owner.SendPacketAsync(new PacketAvatarEquipChangeNotify(this, slot));
                await RecalcStatsAsync(notifyClient);
                return true;
            }

            return false;
        }
        public async Task<bool> UnequipWeapon(bool notifyClient = true)
        {
            WeaponItem item = (WeaponItem)Equips[EquipType.EQUIP_WEAPON];
            Equips.Remove(EquipType.EQUIP_WEAPON);

            //TODO remove weapon openConfigs

            if (item != null)
            {
                item.EquippedAvatar = 0;

                // Update Database
                var inventoryFilter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                var inventoryUpdate = Builders<InventoryManager>.Update.Set($"{nameof(InventoryManager.SubInventories)}.{ItemType.ITEM_WEAPON}.{nameof(WeaponTab.Items)}.{item.Id}.{nameof(WeaponItem.EquippedAvatar)}", item.EquippedAvatar);
                await DatabaseManager.UpdateInventoryAsync(inventoryFilter, inventoryUpdate);

                if (notifyClient) await Owner.SendPacketAsync(new PacketAvatarEquipChangeNotify(this, EquipType.EQUIP_WEAPON));
                await RecalcStatsAsync(notifyClient);
                return true;
            }

            return false;
        }

        public async Task RecalcStatsAsync(bool forceSendAbilityChange = false)
        {
            // Setup
            AvatarPromoteData promoteData = Data.PromoteData[PromoteLevel];

            // Get hp percent, set to 100% if none
            float hpPercent = FightProp[FightProperty.FIGHT_PROP_MAX_HP] == 0 ? 1f : FightProp.GetValueOrDefault(FightProperty.FIGHT_PROP_CUR_HP) / FightProp.GetValueOrDefault(FightProperty.FIGHT_PROP_MAX_HP);

            // Store current energy value for later
            float currentEnergy = GetCurrentEnergy();

            // Clear properties
            FightProp.Clear();
            if (CurSkillDepot.Element != null)
                CurSkillDepot.Element.CurEnergy = 0;

            // Base stats
            FightProp[FightProperty.FIGHT_PROP_BASE_HP] = Data.GetBaseHp(Level);
            FightProp[FightProperty.FIGHT_PROP_BASE_ATTACK] = Data.GetBaseAttack(Level);
            FightProp[FightProperty.FIGHT_PROP_BASE_DEFENSE] = Data.GetBaseDefense(Level);
            FightProp[FightProperty.FIGHT_PROP_CRITICAL] = Data.BaseCritical;
            FightProp[FightProperty.FIGHT_PROP_CRITICAL_HURT] = Data.BaseCriticalHurt;
            FightProp[FightProperty.FIGHT_PROP_CHARGE_EFFICIENCY] = 1f;


            foreach (FightPropData fightPropData in promoteData.addProps)
            {
                FightProp[fightPropData.propType] = FightProp.GetValueOrDefault(fightPropData.propType) + fightPropData.value;
            }

            // Set energy usage
            await SetCurrentEnergy(currentEnergy, false);

            // Artifacts

            // artifact set ids and number of artifacts
            Dictionary<uint, uint> sets = new();

            for (int slotId = 1; slotId <= 5; slotId++)
            {
                // Get artifact

                if (!Equips.TryGetValue((EquipType)slotId, out EquipItem equip))
                {
                    continue;
                }
                // Artifact main stat
                ReliquaryMainPropData mainPropData = GameData.ReliquaryMainPropDataMap[(equip as ReliquaryItem).MainPropId];
                if (mainPropData != null)
                {
                    ReliquaryLevelData levelData = GameData.ReliquaryLevelDataMap[Tuple.Create(equip.ItemData.rankLevel, equip.Level)];
                    if (levelData != null)
                    {
                        FightProp[mainPropData.propType] = FightProp.GetValueOrDefault(mainPropData.propType) + levelData.addProps.Where(w => w.propType == mainPropData.propType).First().value;
                    }
                }
                // Artifact sub stats
                if ((equip as ReliquaryItem).AppendPropIdList != null)
                {
                    foreach (uint appendPropId in (equip as ReliquaryItem).AppendPropIdList)
                    {
                        ReliquaryAffixData affixData = GameData.ReliquaryAffixDataMap[appendPropId];
                        if (affixData != null)
                        {
                            FightProp[affixData.propType] = FightProp.GetValueOrDefault(affixData.propType) + affixData.propValue;
                        }
                    }
                }
                // Set bonus
                if ((equip as ReliquaryItem).ItemData.setId > 0)
                {
                    sets[(equip as ReliquaryItem).ItemData.setId] += 1;
                }
            }

            // Artifact Set stuff
            foreach (KeyValuePair<uint, uint> e in sets.ToList())
            {
                ReliquarySetData setData = GameData.ReliquarySetDataMap[e.Key];
                if (setData == null)
                {
                    continue;
                }

                // Calculate how many items are from the set
                uint amount = e.Value;

                // Add affix data from set bonus
                for (int setIndex = 0; setIndex < setData.setNeedNum.Length; setIndex++)
                {
                    if (amount >= setData.setNeedNum[setIndex])
                    {
                        uint affixId = (uint)((setData.EquipAffixId * 10) + setIndex);

                        EquipAffixData affix = GameData.EquipAffixDataMap[affixId];
                        if (affix == null)
                        {
                            continue;
                        }

                        // Add properties from this affix to our avatar
                        foreach (FightPropData prop in affix.addProps)
                        {
                            if (prop.propType == FightProperty.FIGHT_PROP_NONE) continue;
                            FightProp[prop.propType] = FightProp.GetValueOrDefault(prop.propType) + prop.value;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            // Weapon
            WeaponItem weapon = Weapon;
            if (weapon != null)
            {
                // Add stats
                WeaponCurveData curveData = GameData.WeaponCurveDataMap[weapon.Level];
                if (curveData != null)
                {
                    if (weapon.ItemData.weaponProp != null)
                    {
                        foreach (WeaponProperty weaponProperty in weapon.ItemData.weaponProp)
                        {
                            if (weaponProperty.propType == FightProperty.FIGHT_PROP_NONE) continue;
                            FightProp[weaponProperty.propType] = FightProp.GetValueOrDefault(weaponProperty.propType) + WeaponCurveData.CalcValue(weaponProperty.initValue, curveData.GetArith(weaponProperty.type));
                        }
                    }
                }
                // Weapon promotion stats
                WeaponPromoteData wepPromoteData = GameData.WeaponPromoteDataMap[Tuple.Create(weapon.ItemData.weaponPromoteId, weapon.PromoteLevel)];
                if (wepPromoteData != null)
                {
                    foreach (FightPropData prop in wepPromoteData.addProps)
                    {
                        if (prop.value == 0f || prop.propType == FightProperty.FIGHT_PROP_NONE)
                        {
                            continue;
                        }
                        FightProp[prop.propType] = FightProp.GetValueOrDefault(prop.propType) + prop.value;
                    }
                }
                // Add weapon skill from affixes
                if (weapon.Affixes != null && weapon.Affixes.Count > 0)
                {
                    // Weapons usually dont have more than one affix but just in case...
                    foreach (int af in weapon.Affixes)
                    {
                        if (af == 0)
                        {
                            continue;
                        }
                        // Calculate affix id
                        uint affixId = (uint)((af * 10) + weapon.Refinement);
                        EquipAffixData affix = GameData.EquipAffixDataMap[affixId];
                        if (affix == null)
                        {
                            continue;
                        }

                        // Add properties from this affix to our avatar
                        foreach (FightPropData prop in affix.addProps)
                        {
                            FightProp[prop.propType] = FightProp.GetValueOrDefault(prop.propType) + prop.value;
                        }
                    }
                }
            }

            // Proud skills
            foreach (ProudSkillData proudSkill in CurSkillDepot.InherentProudSkillOpens)
            {
                // Add properties from this proud skill to our avatar
                if (proudSkill.addProps != null)
                {
                    foreach (FightPropData prop in proudSkill.addProps)
                    {
                        FightProp[prop.propType] = FightProp.GetValueOrDefault(prop.propType) + prop.value;
                    }
                }
            }

            // Set % stats
            FightProp[FightProperty.FIGHT_PROP_MAX_HP] =
                (FightProp[FightProperty.FIGHT_PROP_BASE_HP] * (1f + FightProp.GetValueOrDefault(FightProperty.FIGHT_PROP_HP_PERCENT))) + FightProp.GetValueOrDefault(FightProperty.FIGHT_PROP_HP);
            FightProp[FightProperty.FIGHT_PROP_CUR_ATTACK] =
                FightProp[FightProperty.FIGHT_PROP_BASE_ATTACK] * (1f + FightProp.GetValueOrDefault(FightProperty.FIGHT_PROP_ATTACK_PERCENT)) + FightProp.GetValueOrDefault(FightProperty.FIGHT_PROP_ATTACK);
            FightProp[FightProperty.FIGHT_PROP_CUR_DEFENSE] =
                FightProp[FightProperty.FIGHT_PROP_BASE_DEFENSE] * (1f + FightProp.GetValueOrDefault(FightProperty.FIGHT_PROP_DEFENSE_PERCENT)) + FightProp.GetValueOrDefault(FightProperty.FIGHT_PROP_DEFENSE);

            // Set current hp
            FightProp[FightProperty.FIGHT_PROP_CUR_HP] = FightProp[FightProperty.FIGHT_PROP_MAX_HP] * hpPercent;

            // Update Database
            var filter = Builders<AvatarManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var updateQuery = Builders<AvatarManager>.Update.Set($"{nameof(AvatarManager.Avatars)}.{AvatarId}.{nameof(FightProp)}", FightProp);
            await DatabaseManager.UpdateAvatarsAsync(filter, updateQuery);

            // Packet
            if (Owner.HasSentLoginPackets)
            {
                // Update stats for client
                await Owner.SendPacketAsync(new PacketAvatarFightPropNotify(this));
            }
        }

        public AvatarInfo ToProto()
        {
            int fetterLevel = Fetters.FetterLevel;
            AvatarFetterInfo avatarFetter = new AvatarFetterInfo() { ExpLevel = (uint)fetterLevel };

            if (fetterLevel != 10)
            {
                avatarFetter.ExpNumber = (uint)Fetters.FetterExp;
            }
            else
            {
                avatarFetter.RewardedFetterLevelList.Add(10);
            }
            foreach (FetterData fetter in Fetters.FetterStates.Values)
            {
                avatarFetter.FetterList.Add(fetter);
            }

            AvatarInfo avatarInfo = new()
            {
                AvatarId = AvatarId,
                Guid = Guid,
                CostumeId = (uint)Costume,
                WearingFlycloakId = (uint)FlyCloak,
                FetterInfo = avatarFetter,
                BornTime = (uint)BornTime,
                SkillDepotId = CurrentDepotId,
                LifeState = (uint)LifeState,
                AvatarType = 1,
                CoreProudSkillLevel = CurSkillDepot.GetCoreProudSkillLevel()
            };

            foreach (ProudSkillData proud in CurSkillDepot.InherentProudSkillOpens)
            {
                avatarInfo.InherentProudSkillList.Add(proud.proudSkillId);
            }
            foreach (uint talent in CurSkillDepot.Talents)
            {
                avatarInfo.TalentIdList.Add(talent);
            }
            foreach (uint skill in CurSkillDepot.GetSkillLevelMap().Keys)
            {
                avatarInfo.SkillLevelMap.Add(skill, CurSkillDepot.GetSkillLevelMap()[skill]);
            }
            foreach (FightProperty prop in FightProp.Keys)
            {
                avatarInfo.FightPropMap.Add((uint)prop, FightProp[prop]);
            }
            foreach (uint groupId in CurSkillDepot.ProudSkillExtraLevelMap.Keys)
            {
                avatarInfo.ProudSkillExtraLevelMap.Add(groupId, CurSkillDepot.ProudSkillExtraLevelMap[groupId]);
            }
            foreach (uint skillId in CurSkillDepot.SkillExtraChargeMap.Keys)
            {
                avatarInfo.SkillMap.Add(skillId, new AvatarSkillInfo() { MaxChargeCount = CurSkillDepot.SkillExtraChargeMap[skillId] });
            }

            foreach (GameItem item in Equips.Values)
            {
                avatarInfo.EquipGuidList.Add(item.Guid);
            }

            avatarInfo.PropMap.Add((uint)PlayerProperty.PROP_LEVEL, new PropValue() { Type = (uint)PlayerProperty.PROP_LEVEL, Ival = Level, Val = Level });
            avatarInfo.PropMap.Add((uint)PlayerProperty.PROP_EXP, new PropValue() { Type = (uint)PlayerProperty.PROP_EXP, Ival = (uint)Exp, Val = (uint)Exp });
            avatarInfo.PropMap.Add((uint)PlayerProperty.PROP_BREAK_LEVEL, new PropValue() { Type = (uint)PlayerProperty.PROP_BREAK_LEVEL, Ival = (uint)PromoteLevel, Val = (uint)PromoteLevel });
            avatarInfo.PropMap.Add((uint)PlayerProperty.PROP_SATIATION_VAL, new PropValue() { Type = (uint)PlayerProperty.PROP_SATIATION_VAL, Ival = 0, Val = 0 });
            avatarInfo.PropMap.Add((uint)PlayerProperty.PROP_SATIATION_PENALTY_TIME, new PropValue() { Type = (uint)PlayerProperty.PROP_SATIATION_PENALTY_TIME, Ival = 0, Val = 0 });

            return avatarInfo;
        }

        // used only in character showcase
        public ShowAvatarInfo ToShowAvatarInfoProto()
        {
            int fetterLevel = Fetters.FetterLevel;
            AvatarFetterInfo avatarFetter = new() { ExpLevel = (uint)fetterLevel };

            ShowAvatarInfo showAvatarInfo = new()
            {
                AvatarId = AvatarId,
                CostumeId = Costume,
                SkillDepotId = CurrentDepotId,
                CoreProudSkillLevel = CurSkillDepot.GetCoreProudSkillLevel(),
                FetterInfo = avatarFetter
            };
            foreach (uint talent in CurSkillDepot.Talents)
            {
                showAvatarInfo.TalentIdList.Add(talent);
            }
            foreach (ProudSkillData proudSkill in CurSkillDepot.InherentProudSkillOpens)
            {
                showAvatarInfo.InherentProudSkillList.Add(proudSkill.proudSkillId);
            }
            foreach (uint skill in CurSkillDepot.GetSkillLevelMap().Keys)
            {
                showAvatarInfo.SkillLevelMap.Add(skill, CurSkillDepot.GetSkillLevelMap()[skill]);
            }
            foreach (uint groupId in CurSkillDepot.ProudSkillExtraLevelMap.Keys)
            {
                showAvatarInfo.ProudSkillExtraLevelMap.Add(groupId, CurSkillDepot.ProudSkillExtraLevelMap[groupId]);
            }
            foreach (FightProperty prop in FightProp.Keys)
            {
                showAvatarInfo.FightPropMap.Add((uint)prop, FightProp[prop]);
            }


            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_LEVEL, new PropValue() { Type = (uint)PlayerProperty.PROP_LEVEL, Ival = (uint)Level, Val = (uint)Level });
            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_EXP, new PropValue() { Type = (uint)PlayerProperty.PROP_EXP, Ival = (uint)Exp, Val = (uint)Exp });
            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_BREAK_LEVEL, new PropValue() { Type = (uint)PlayerProperty.PROP_BREAK_LEVEL, Ival = PromoteLevel, Val = PromoteLevel });
            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_SATIATION_VAL, new PropValue() { Type = (uint)PlayerProperty.PROP_SATIATION_VAL, Ival = (uint)Satiation, Val = (uint)Satiation });
            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_SATIATION_PENALTY_TIME, new PropValue() { Type = (uint)PlayerProperty.PROP_SATIATION_VAL, Ival = (uint)SatiationPenalty, Val = (uint)SatiationPenalty });
            int maxStamina = Owner.PlayerProperties[PlayerProperty.PROP_MAX_STAMINA];
            showAvatarInfo.PropMap.Add((uint)PlayerProperty.PROP_MAX_STAMINA, new PropValue() { Type = (uint)PlayerProperty.PROP_MAX_STAMINA, Ival = (uint)maxStamina, Val = (uint)maxStamina });

            foreach (ReliquaryItem item in Equips.Values)
            {
                showAvatarInfo.EquipList.Add(new ShowEquip()
                {
                    ItemId = (uint)item.ItemId,
                    Reliquary = item.ToReliquaryProto()
                });
            }

            WeaponItem weapon = (WeaponItem)Equips[EquipType.EQUIP_WEAPON];
            showAvatarInfo.EquipList.Add(new ShowEquip()
            {
                ItemId = (uint)weapon.ItemId,
                Weapon = weapon.ToWeaponProto()
            });

            return showAvatarInfo;
        }
    }
}
