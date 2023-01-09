using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class WeaponTab : InventoryTab
    {
        [BsonIgnore] public new const int InventoryLimit = 2000;
        private static string mongoPathToItems = $"{nameof(InventoryManager.SubInventories)}.{ItemType.ITEM_WEAPON}";
        [BsonElement] private uint NextWeaponId = 1; // Is it possible to collect this many items? O.o
        // Use Mongodb unique (for the player) id for weapons
        [BsonSerializer(typeof(UIntDictionarySerializer<MaterialItem>))]
        public Dictionary<uint, MaterialItem> UpgradeMaterials = new(); // id

        public WeaponTab(Player.Player owner, InventoryManager inventory) : base(owner, inventory) { }

        public override async Task OnLoadAsync(Player.Player owner, InventoryManager inventory)
        {
            Owner = owner;
            Inventory = inventory;
            foreach (WeaponItem item in Items.Values)
            {
                item.Guid = Owner.GetNextGameGuid();
                Inventory.GuidMap.Add(item.Guid, item);
                if (item.EquippedAvatar != 0) await inventory.EquipWeaponAsync(owner.Avatars.Avatars[item.EquippedAvatar].Guid, item.Guid);
            }
            foreach (MaterialItem item in UpgradeMaterials.Values)
            {
                item.Guid = Owner.GetNextGameGuid();
                Inventory.GuidMap.Add(item.Guid, item);
            }
        }

        public override async Task<GameItem> AddItemAsync(uint itemId, int count = 1, uint level = 1, uint refinement = 0)
        {

            if (GameData.ItemDataMap[itemId].itemType == ItemType.ITEM_MATERIAL)
            {
                if (UpgradeMaterials.TryGetValue(itemId, out MaterialItem material))
                {
                    if (material.ItemData.stackLimit >= material.Count + count)
                    {
                        material.Count += count;

                        // Update Database
                        var filter1 = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                        var update1 = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{nameof(UpgradeMaterials)}.{itemId}.{nameof(GameItem.Count)}", material.Count);
                        await DatabaseManager.UpdateInventoryAsync(filter1, update1);

                        //TODO update codex
                        return material;
                    }
                    else return null;
                }
                else
                {
                    var newMaterial = new MaterialItem(Owner.GetNextGameGuid(), itemId, count);
                    UpgradeMaterials.Add(itemId, newMaterial);

                    // Update Database
                    var filter2 = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update2 = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{nameof(UpgradeMaterials)}.{itemId}", newMaterial);
                    await DatabaseManager.UpdateInventoryAsync(filter2, update2);

                    //TODO update codex
                    return newMaterial;
                }
            }

            if (Items.Count == InventoryLimit)
            {
                return null;
            }

            var weapon = new WeaponItem(Owner.GetNextGameGuid(), itemId, NextWeaponId++, level, refinement);
            Items.Add(weapon.Id, weapon);

            // Update Database
            var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var update = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{nameof(Items)}.{weapon.Id}", weapon).Inc($"{mongoPathToItems}.{nameof(NextWeaponId)}", 1);
            await DatabaseManager.UpdateInventoryAsync(filter, update);

            //TODO update codex
            return weapon;
        }

        public async Task<WeaponItem> UpgradeWeaponAsync(ulong guid, IEnumerable<ulong> foodWeaponGuidList, IEnumerable<ItemParam> itemParamList) 
        {
            WeaponItem weapon = Inventory.GuidMap[guid] as WeaponItem;
            List<ItemParam> leftoverOres = new(); //TODO
            List<ItemParamData> xpMats = new();
            List<WeaponItem> weaponItems = new();
            if (weapon is null || weapon.PromoteData is null)
                return null;
            uint expGain = 0;
            uint expGainFree = 0;
            foreach (var itemParam in itemParamList)
            {
                var matData = GameData.ItemDataMap[itemParam.ItemId] as MaterialData;

                foreach (var x in matData.itemUse.Where(o => o.useOp == Enums.ItemUseOp.ITEM_USE_ADD_WEAPON_EXP))
                {
                    expGain += uint.Parse(x.useParam[0]) * itemParam.Count; //probably not the ideal way to go about it
                    xpMats.Add(new ItemParamData(itemParam.ItemId, (int)itemParam.Count));

                }
            }
            foreach (ulong matGuid in foodWeaponGuidList)
            {
                if (Inventory.GuidMap[matGuid] is not WeaponItem mat || mat.Locked)
                    continue;
                weaponItems.Add(mat);
                if (mat.TotalExp > 0)
                {
                    expGainFree += (mat.TotalExp * 4) / 5; //Only 80% cashback! 
                }
                expGain += mat.ItemData.weaponBaseExp;
            }
            uint moraCost = expGain / 10;
            expGain += expGainFree;
            uint exp = weapon.Exp;
            uint level = weapon.Level;
            uint oldLevel = level;
            xpMats.Add(new ItemParamData(202, (int)moraCost));
            if (await PayUpgradeCostAsync(xpMats, weaponItems))
            {
                uint reqExp = GameData.WeaponLevelDataMap[level].requiredExps[weapon.ItemData.rankLevel - 1];
                while (expGain > 0 && level < weapon.PromoteData.unlockMaxLevel)
                {
                    uint toGain = Math.Min(expGain, reqExp - exp);
                    exp += toGain;
                    weapon.TotalExp += toGain;
                    expGain -= toGain;
                    if (exp >= reqExp)
                    {
                        exp = 0;
                        level += 1;
                        reqExp = GameData.WeaponLevelDataMap[level].requiredExps[weapon.ItemData.rankLevel - 1];
                    }

                }
                weapon.Level = (uint)level;
                weapon.Exp = exp;
                var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                var update = Builders<InventoryManager>.Update.
                    Set($"{mongoPathToItems}.{nameof(Items)}.{weapon.Id}.{nameof(weapon.Level)}", weapon.Level).
                    Set($"{mongoPathToItems}.{nameof(Items)}.{weapon.Id}.{nameof(weapon.Exp)}", weapon.Exp).
                    Set($"{mongoPathToItems}.{nameof(Items)}.{weapon.Id}.{nameof(weapon.TotalExp)}", weapon.TotalExp);
                await DatabaseManager.UpdateInventoryAsync(filter, update);
                await Owner.SendPacketAsync(new PacketStoreItemChangeNotify(weapon));
                return weapon;
            }
            return null;
        }

        public async Task<bool> PayUpgradeCostAsync(IEnumerable<ItemParamData> costItems, IEnumerable<WeaponItem> foodWeapons)
        {
            Dictionary<MaterialItem, int> materials = new();
            Dictionary<uint, int> virtualItems = new();
            foreach (ItemParamData itemData in costItems)
            {
                if (GameData.ItemDataMap[itemData.id].itemType == ItemType.ITEM_MATERIAL)
                {
                    if (!UpgradeMaterials.TryGetValue(itemData.id, out MaterialItem? material))
                        return false;
                    if (material.Count < itemData.count) return false; // insufficient materials
                    else materials.Add(material, itemData.count);
                }
                else if (GameData.ItemDataMap[itemData.id].itemType == ItemType.ITEM_VIRTUAL)
                {
                    if (Inventory.GetVirtualItemValue(itemData.id) < itemData.count) return false; // insufficient currency
                    else virtualItems.Add(itemData.id, itemData.count);
                }
            }
            // We have the requisite amount for all items
            foreach (var material in materials) await RemoveItemAsync(material.Key, material.Value);
            foreach (uint item in virtualItems.Keys) await Inventory.PayVirtualItemByIdAsync(item, virtualItems[item]);
            foreach (var foodWeapon in foodWeapons) await RemoveItemAsync(foodWeapon);
            return true;
        }

        public async Task<WeaponItem> PromoteWeaponAsync(ulong targetWeaponGuid)
        {
            WeaponItem weapon = Inventory.GuidMap[targetWeaponGuid] as WeaponItem;
            GameData.WeaponPromoteDataMap.TryGetValue(Tuple.Create(weapon.ItemData.weaponPromoteId, weapon.PromoteLevel + 1), out WeaponPromoteData? promoteData);
            if (promoteData is null || Owner.PlayerProperties[PlayerProperty.PROP_PLAYER_LEVEL] < promoteData.requiredPlayerLevel)
                return null;
            List<ItemParamData> costItems = promoteData.costItems.ToList();
            costItems.Add(new ItemParamData(202, promoteData.coinCost));
            if(await Inventory.PayPromoteCostAsync(costItems))
            {
                weapon.PromoteLevel += 1;
                var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                var update = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{nameof(Items)}.{weapon.Id}.{nameof(weapon.PromoteLevel)}", weapon.PromoteLevel);
                await DatabaseManager.UpdateInventoryAsync(filter, update);
            }
            return weapon;
        }
        internal override async Task<bool> RemoveItemAsync(GameItem item, int count = 1)
        {
            if (item is WeaponItem && Items.TryGetValue((item as WeaponItem).Id, out GameItem? weapon))
            {
                if ((weapon as WeaponItem).EquippedAvatar != 0)
                {
                    await Owner.Avatars.Avatars[(weapon as WeaponItem).EquippedAvatar].UnequipWeapon();
                }

                // Update Database
                var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                var update = Builders<InventoryManager>.Update.Unset($"{mongoPathToItems}.{nameof(Items)}.{weapon.Id}");
                await DatabaseManager.UpdateInventoryAsync(filter, update);

                Items.Remove(weapon.Id);
                Inventory.GuidMap.Remove(weapon.Guid);
                weapon.Count = 0;
                await Owner.SendPacketAsync(new PacketStoreItemDelNotify(weapon));
                return true;
            }
            else if (UpgradeMaterials.TryGetValue(item.ItemId, out MaterialItem material))
            {
                if (material.Count - count >= 1)
                {
                    material.Count -= count;

                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{nameof(UpgradeMaterials)}.{material.ItemId}.{nameof(GameItem.Count)}", material.Count);
                    await DatabaseManager.UpdateInventoryAsync(filter, update);

                    await Owner.SendPacketAsync(new PacketStoreItemChangeNotify(material));
                    return true;
                }
                else if (material.Count - count == 0)
                {
                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Unset($"{mongoPathToItems}.{nameof(UpgradeMaterials)}.{material.ItemId}.{nameof(GameItem.Count)}");
                    await DatabaseManager.UpdateInventoryAsync(filter, update);
                    
                    UpgradeMaterials.Remove(material.ItemId);
                    material.Count = 0;
                    Inventory.GuidMap.Remove(material.Guid);
                    await Owner.SendPacketAsync(new PacketStoreItemDelNotify(material));
                    return true;
                }
                else
                {
                    Logger.WriteErrorLine("ItemId: " + item.ItemId + ". Tried to remove " + count + " have " + item.Count);
                    return false;
                }
            }
            else
            {
                Logger.WriteErrorLine("Tried to remove inexistent item");
                return false;
            }
        }
        public async Task<bool> EquipWeaponAsync(ulong avatarGuid, ulong equipGuid)
        {
            Avatar.Avatar? avatar = Owner.Avatars.GetAvatarByGuid(avatarGuid);

            if (avatar != null && Inventory.GuidMap.TryGetValue(equipGuid, out GameItem weapon) && weapon.ItemData.itemType == ItemType.ITEM_WEAPON)
            {
                // Is it equipped at another avatar?
                Avatar.Avatar? otherAvatar = Owner.Avatars.Avatars.Values.Where(a => a.Weapon == weapon && a != avatar).FirstOrDefault();
                if (otherAvatar != null)
                {
                    await UnequipWeaponAsync(otherAvatar.Guid);
                }
                WeaponItem asWeapon = (WeaponItem)weapon;
                if (avatar.Data.GeneralData.weaponType == asWeapon.ItemData.weaponType)
                {
                    if (await avatar.EquipWeapon(asWeapon, true))
                        asWeapon.EquippedAvatar = avatar.AvatarId;
                    return true;
                }
            }

            return false;
        }
        public async Task<bool> UnequipWeaponAsync(ulong avatarGuid)
        {
            Avatar.Avatar? avatar = Owner.Avatars.GetAvatarByGuid(avatarGuid);

            if (avatar != null)
            {

                return await avatar.UnequipWeapon();

            }

            return false;
        }
    }
}
