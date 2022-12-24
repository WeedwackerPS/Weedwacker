using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class FurnitureTab : InventoryTab
    {
        [BsonIgnore] public new const int InventoryLimit = 2000;
        [BsonSerializer(typeof(IntDictionarySerializer<MaterialItem>))]
        public Dictionary<int, MaterialItem> Materials = new(); // ItemId

        private static string mongoPathToItems = $"{nameof(InventoryManager.SubInventories)}.{ItemType.ITEM_FURNITURE}";
        public FurnitureTab(Player.Player owner, InventoryManager inventory) : base(owner, inventory) { }

        public override async Task OnLoadAsync(Player.Player owner, InventoryManager inventory)
        {
            Owner = owner;
            Inventory = inventory;
            foreach (FurnitureItem item in Items.Values)
            {
                item.Guid = Owner.GetNextGameGuid();
                Inventory.GuidMap.Add(item.Guid, item);
            }
            foreach (MaterialItem item in Materials.Values)
            {
                item.Guid = Owner.GetNextGameGuid();
                Inventory.GuidMap.Add(item.Guid, item);
            }
        }

        //TODO FurnitureItem
        public override async Task<GameItem?> AddItemAsync(int itemId, int count = 1, int level = 1, int refinement = 0)
        {

            if (GameData.ItemDataMap[itemId].itemType == ItemType.ITEM_MATERIAL)
            {
                if (Materials.TryGetValue(itemId, out MaterialItem? material))
                {
                    if (material.ItemData.stackLimit >= material.Count + count)
                    {
                        material.Count += count;

                        // Update Database
                        var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                        var update = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{nameof(Materials)}.{itemId}.{nameof(GameItem.Count)}", material.Count);
                        await DatabaseManager.UpdateInventoryAsync(filter, update);

                        //TODO update codex
                        return material;
                    }
                    else return null;
                }
                else
                {
                    var newMaterial = new MaterialItem(Owner.GetNextGameGuid(), itemId, count);
                    Materials.Add(itemId, newMaterial);

                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{nameof(Materials)}.{itemId}", newMaterial);
                    await DatabaseManager.UpdateInventoryAsync(filter, update);

                    //TODO update codex
                    return newMaterial;
                }
            }

            //TODO Furniture
            return null;
        }

        //TODO FurnitureItem
        internal override async Task<bool> RemoveItemAsync(GameItem item, int count = 1)
        {
            if (Materials.TryGetValue((item as MaterialItem).ItemId, out MaterialItem? material))
            {
                if (material.Count - count >= 1)
                {
                    material.Count -= count;

                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{nameof(Materials)}.{material.ItemId}.{nameof(GameItem.Count)}", material.Count);
                    await DatabaseManager.UpdateInventoryAsync(filter, update);

                    await Owner.SendPacketAsync(new PacketStoreItemChangeNotify(material));
                    return true;
                }
                else if (material.Count - count == 0)
                {
                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Unset($"{mongoPathToItems}.{nameof(Materials)}.{material.ItemId}");
                    await DatabaseManager.UpdateInventoryAsync(filter, update);

                    material.Count = 0;
                    Inventory.GuidMap.Remove(material.Guid);
                    Materials.Remove(material.ItemId);
                    await Owner.SendPacketAsync(new PacketStoreItemDelNotify(material));
                    return true;
                }
                else
                {
                    Logger.WriteErrorLine("ItemId: " + item.ItemId + ". Tried to remove " + count + " have " + item.Count);
                    return false;
                }
            }
            else if (item.ItemData.itemType == ItemType.ITEM_FURNITURE)
            {
                Logger.WriteErrorLine("Furniture not implemented yet :(");
                return false;
            }
            else
            {
                Logger.WriteErrorLine("Tried to remove inexistent item");
                return false;
            }
        }
    }
}
