using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class WeaponTab : InventoryTab
    {
        [BsonIgnore] public new const int InventoryLimit = 2000;
        private static string mongoPathToItems = $"{nameof(InventoryManager.SubInventories)}.{ItemType.ITEM_WEAPON}";
        [BsonElement] private int NextWeaponId = 1; // Is it possible to collect this many items? O.o
        // Use Mongodb unique (for the player) id for weapons
        [BsonSerializer(typeof(IntDictionarySerializer<MaterialItem>))]
        public Dictionary<int, MaterialItem> UpgradeMaterials = new(); // id

        public WeaponTab(Player.Player owner, InventoryManager inventory) : base(owner, inventory) { }

        public override async Task OnLoadAsync(Player.Player owner, InventoryManager inventory)
        {
            Owner = owner;
            Inventory = inventory;
            foreach (WeaponItem item in Items.Values)
            {
                item.Guid = Owner.GetNextGameGuid();
                Inventory.GuidMap.Add(item.Guid, item);
                if (item.EquippedAvatar != 0) await inventory.EquipWeapon(owner.Avatars.Avatars[item.EquippedAvatar].Guid, item.Guid);
            }
            foreach (MaterialItem item in UpgradeMaterials.Values)
            {
                item.Guid = Owner.GetNextGameGuid();
                Inventory.GuidMap.Add(item.Guid, item);
            }
        }

        public override async Task<GameItem> AddItemAsync(int itemId, int count = 1, int level = 1, int refinement = 0)
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


        internal override async Task<bool> RemoveItemAsync(GameItem item, int count = 1)
        {
            if (Items.TryGetValue((item as WeaponItem).Id, out GameItem? weapon))
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
                return true;
            }
            else if (UpgradeMaterials.TryGetValue((item as MaterialItem).ItemId, out MaterialItem material))
            {
                if (material.Count - count >= 1)
                {
                    material.Count -= count;

                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{nameof(UpgradeMaterials)}.{material.ItemId}.{nameof(GameItem.Count)}", material.Count);
                    await DatabaseManager.UpdateInventoryAsync(filter, update);

                    return true;
                }
                else if (material.Count - count == 0)
                {
                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Unset($"{mongoPathToItems}.{nameof(UpgradeMaterials)}.{material.ItemId}.{nameof(GameItem.Count)}");
                    await DatabaseManager.UpdateInventoryAsync(filter, update);

                    UpgradeMaterials.Remove(material.ItemId);
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
    }
}
