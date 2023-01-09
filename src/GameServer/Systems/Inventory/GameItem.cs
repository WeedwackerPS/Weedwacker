using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Inventory
{
    [BsonDiscriminator(RootClass = true)]
    [BsonKnownTypes(typeof(MaterialItem), typeof(EquipItem))]
    internal abstract class GameItem
    {
        [BsonId]
        [BsonElement("_id")]
        public uint Id { get; protected set; }
        [BsonElement] public uint ItemId { get; protected set; }
        public int Count;
        [BsonIgnore] public ulong Guid; // Player unique id. Generated each session
        [BsonIgnore] public bool IsNew { get; protected set; } = false;
        [BsonIgnore] public ItemData ItemData => GameData.ItemDataMap[ItemId];


        public GameItem(ulong guid, uint itemId, int count)
        {
            Guid = guid;
            ItemId = itemId;
            IsNew = true;
        }

        public abstract Item ToProto();

        public ItemHint ToItemHintProto()
        {
            var hint = new ItemHint() { ItemId = (uint)ItemId, Count = (uint)Count, IsNew = IsNew, Guid = (ulong)Guid };
            if (IsNew) IsNew = false;
            return hint;
        }
    }
}
