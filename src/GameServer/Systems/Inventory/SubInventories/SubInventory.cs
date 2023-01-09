using MongoDB.Bson.Serialization.Attributes;

namespace Weedwacker.GameServer.Systems.Inventory
{
    [BsonDiscriminator(RootClass = true)]
    [BsonKnownTypes(typeof(MaterialSubInv), typeof(InventoryTab))]
    internal abstract class SubInventory
    {
        [BsonIgnore] protected Player.Player? Owner;
        [BsonIgnore] protected InventoryManager? Inventory;

        public SubInventory(Player.Player owner, InventoryManager inventory)
        {
            Owner = owner;
            Inventory = inventory;
        }

        // return null if no update item
        public abstract Task<GameItem?> AddItemAsync(uint itemId, int count = 1, uint level = 1, uint refinement = 0);
        // Delete if count reaches 0
        internal abstract Task<bool> RemoveItemAsync(GameItem item, int count = 1);

        // Called by DatabaseManager
        public abstract Task OnLoadAsync(Player.Player owner, InventoryManager inventory);
    }
}
