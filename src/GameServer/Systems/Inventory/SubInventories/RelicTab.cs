using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class RelicTab : InventoryTab
    {
        [BsonIgnore] public new const int InventoryLimit = 1500;
        private static string mongoPathToItems = $"{nameof(InventoryManager.SubInventories)}.{ItemType.ITEM_RELIQUARY}";
        [BsonElement] private int NextRelicId = 0; // Is it possible to collect 4B items? O.o
        // Use Mongodb unique (for the player) id for the relics
        [BsonSerializer(typeof(IntDictionarySerializer<MaterialItem>))]
        public Dictionary<int, MaterialItem> UpgradeMaterials = new();

        public RelicTab(Player.Player owner, InventoryManager inventory) : base(owner, inventory) { }

        public override async Task OnLoadAsync(Player.Player owner, InventoryManager inventory)
        {
            Owner = owner;
            Inventory = inventory;
            foreach (ReliquaryItem item in Items.Values)
            {
                item.Guid = Owner.GetNextGameGuid();
                if (item.EquippedAvatar != 0) await inventory.EquipRelic(owner.Avatars.Avatars[item.EquippedAvatar].Guid, item.Guid);
            }
            foreach (MaterialItem item in UpgradeMaterials.Values)
            {
                item.Guid = Owner.GetNextGameGuid();
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
                        var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                        var update = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{nameof(UpgradeMaterials)}.{itemId}.{nameof(GameItem.Count)}", material.Count);
                        await DatabaseManager.UpdateInventoryAsync(filter, update);

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
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{nameof(UpgradeMaterials)}.{itemId}", newMaterial);
                    await DatabaseManager.UpdateInventoryAsync(filter, update);

                    //TODO update codex
                    return newMaterial;
                }
            }

            if (Items.Count == InventoryLimit)
            {
                return null;
            }

            var relic = new ReliquaryItem(Owner.GetNextGameGuid(), itemId, NextRelicId++, level);
            Items.Add(relic.Id, relic);

            // Update Database
            var filter2 = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var update2 = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{nameof(Items)}.{relic.Id}", relic).Inc($"{mongoPathToItems}.{nameof(NextRelicId)}", 1);
            await DatabaseManager.UpdateInventoryAsync(filter2, update2);

            //TODO update codex
            return relic;
        }

        internal override async Task<bool> RemoveItemAsync(GameItem item, int count = 1)
        {
            if (Items.TryGetValue((item as ReliquaryItem).Id, out GameItem? relic))
            {
                if ((relic as ReliquaryItem).EquippedAvatar != 0)
                {
                    await Owner.Avatars.Avatars[(relic as ReliquaryItem).EquippedAvatar].UnequipRelic((relic as ReliquaryItem).ItemData.equipType);
                }

                // Update Database
                var filter2 = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                var update2 = Builders<InventoryManager>.Update.Unset($"{mongoPathToItems}.{nameof(Items)}.{relic.Id}");
                await DatabaseManager.UpdateInventoryAsync(filter2, update2);

                Items.Remove((relic as ReliquaryItem).Id);
                Inventory.GuidMap.Remove(relic.Guid);
                relic.Count = 0;
                await Owner.SendPacketAsync(new PacketStoreItemDelNotify(relic));
                return true;
            }
            else if (UpgradeMaterials.TryGetValue((item as MaterialItem).ItemId, out MaterialItem material))
            {
                if (material.Count - count >= 1)
                {
                    material.Count -= count;

                    // Update Database
                    var filter2 = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update2 = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{nameof(UpgradeMaterials)}.{material.ItemId}.{nameof(GameItem.Count)}", material.Count);
                    await DatabaseManager.UpdateInventoryAsync(filter2, update2);

                    await Owner.SendPacketAsync(new PacketStoreItemChangeNotify(material));
                    return true;
                }
                else if (material.Count - count == 0)
                {
                    // Update Database
                    var filter2 = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update2 = Builders<InventoryManager>.Update.Unset($"{mongoPathToItems}.{nameof(Items)}.{material.ItemId}");
                    await DatabaseManager.UpdateInventoryAsync(filter2, update2);
                  
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
    }
}
