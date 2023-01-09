using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class ReliquaryItem : EquipItem
    {
        [BsonElement] public uint MainPropId { get; protected set; }
        [BsonElement] public HashSet<uint>? AppendPropIdList { get; private set; } = new();
        [BsonIgnore] public new ReliquaryData ItemData => (ReliquaryData)GameData.ItemDataMap[ItemId];
        public ReliquaryItem(ulong guid, uint itemId, uint uniqueId, uint level = 1) : base(guid, itemId)
        {
            Id = uniqueId;
            Level = level;

            // Create main property
            Random rand = new();
            ReliquaryMainPropData mainPropData = GameData.ReliquaryMainPropDataMap.ElementAt(rand.Next(0, GameData.ReliquaryMainPropDataMap.Count)).Value;
            MainPropId = mainPropData.id;

            // Create extra stats
            AppendPropIdList.Add(ItemData.appendPropNum);
        }

        public async Task OnLoadAsync(ulong guid)
        {
            Guid = guid;
        }
        public EquipType GetEquipSlot()
        {
            return ItemData.equipType;
        }
        public Reliquary ToReliquaryProto()
        {
            Reliquary relic = new()
            {
                Level = (uint)Level,
                Exp = (uint)Exp,
                PromoteLevel = (uint)PromoteLevel,
                MainPropId = (uint)MainPropId,
            };
            foreach (int id in AppendPropIdList)
            {
                relic.AppendPropIdList.Add((uint)id);
            }

            return relic;
        }

        public SceneReliquaryInfo CreateSceneReliquaryInfo()
        {
            SceneReliquaryInfo relicInfo = new SceneReliquaryInfo()
            {
                ItemId = (uint)ItemId,
                Guid = Guid,
                Level = (uint)Level
            };

            return relicInfo;
        }

        public override Item ToProto()
        {
            Item proto = new()
            {
                Guid = Guid,
                ItemId = (uint)ItemData.id
            };

            Reliquary relic = ToReliquaryProto();
            proto.Equip = new Equip() { Reliquary = relic, IsLocked = Locked };
            return proto;
        }
    }
}
