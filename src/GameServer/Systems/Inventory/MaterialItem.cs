using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class MaterialItem : GameItem
    {
        [BsonIgnore] public new MaterialData ItemData => (MaterialData)GameData.ItemDataMap[ItemId];

        public MaterialItem(ulong guid, uint itemId, int count) : base(guid, itemId, count)
        {
            Count = count;
        }

        public override Item ToProto()
        {
            Item proto = new()
            {
                Guid = Guid,
                ItemId = (uint)ItemData.id,
                Material = new() { Count = (uint)Count }
            };

            return proto;
        }
    }
}
