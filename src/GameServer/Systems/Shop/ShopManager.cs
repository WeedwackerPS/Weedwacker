using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Database;

namespace Weedwacker.GameServer.Systems.Shop
{
    internal class ShopManager
    {
        [BsonElement("_id")]
        [BsonId] public uint OwnerId { get; private set; }
        private Player.Player Owner;
        [BsonSerializer(typeof(IntSortedListSerializer<Shop>))]
        public SortedList<int, Shop> Shops = new(); // shopType
        public ShopManager(Player.Player owner)
        {
            Owner = owner;
            OwnerId = owner.GameUid;
        }

        public bool HasShop(int shopType, out Shop? shop)
        {
            if (Shops.ContainsKey(shopType))
            {
                shop = Shops[shopType];
                return true;
            }
            else
            {
                var shops = GameData.ShopDataMap.Where(w => (int)w.Value.shopType == shopType);
                if (shops.Any())
                {
                    Shop newShop = new Shop(Owner, shopType);
                    Shops.Add(shopType, newShop);
                    shop = newShop;
                    return true;
                }
                else
                {
                    shop = null;
                    return false;
                }
            }
        }
        public async Task OnLoadAsync(Player.Player owner)
        {
            Owner = owner;
            Shops.Values.AsParallel().ForAll(w => w.Goods.AsParallel().ForAll(p => p.OnLoadAsync()));
        }
    }
}
