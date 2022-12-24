using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Inventory
{
    [BsonKnownTypes(typeof(FoodTab),
    typeof(GadgetTab), typeof(PreciousTab),
    typeof(PromoteTab), typeof(QuestTab))]
    internal class MaterialsTab : InventoryTab
    {
        private string mongoPathToItems = $"{nameof(InventoryManager.SubInventories)}.{ItemType.ITEM_MATERIAL}.{nameof(MaterialsTab)}.{nameof(Items)}";
        [BsonIgnore] public new const int InventoryLimit = 2000;

        public MaterialsTab(Player.Player owner, InventoryManager inventory) : base(owner, inventory) { }

        public override async Task OnLoadAsync(Player.Player owner, InventoryManager inventory)
        {
            Owner = owner;
            Inventory = inventory;
            foreach (MaterialItem item in Items.Values)
            {
                item.Guid = Owner.GetNextGameGuid();
                inventory.GuidMap.Add(item.Guid, item);
            }
        }

        public override async Task<GameItem?> AddItemAsync(int itemId, int count = 1, int level = 1, int refinement = 0)
        {
            if (Items.TryGetValue(itemId, out GameItem? material))
            {
                if ((material as MaterialItem).ItemData.stackLimit >= material.Count + count)
                {
                    material.Count += count;

                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{itemId}.{nameof(GameItem.Count)}", material.Count);
                    await DatabaseManager.UpdateInventoryAsync(filter, update);

                    //TODO update codex
                    return material;
                }
                else return null;
            }
            else
            {
                var newMaterial = new MaterialItem(Owner.GetNextGameGuid(), itemId, count);
                Items.Add(itemId, newMaterial);

                // Update Database
                var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                var update = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{itemId}", newMaterial);
                await DatabaseManager.UpdateInventoryAsync(filter, update);

                //TODO update codex
                return newMaterial;
            }
        }

        internal override async Task<bool> RemoveItemAsync(GameItem item, int count = 1)
        {
            if (Items.TryGetValue((item as MaterialItem).ItemId, out GameItem? material))
            {
                if (material.Count - count >= 1)
                {
                    material.Count -= count;

                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{material.ItemId}.{nameof(GameItem.Count)}", material.Count);
                    await DatabaseManager.UpdateInventoryAsync(filter, update);

                    await Owner.SendPacketAsync(new PacketStoreItemChangeNotify(material));
                    return true;
                }
                else if (material.Count - count == 0)
                {
                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Unset($"{mongoPathToItems}.{material.ItemId}");
                    await DatabaseManager.UpdateInventoryAsync(filter, update);

                    Items.Remove(material.ItemId);
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
