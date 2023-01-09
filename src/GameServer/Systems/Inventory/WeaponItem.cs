using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class WeaponItem : EquipItem
    {
        [BsonElement] public List<int>? Affixes { get; protected set; } = new();
        [BsonElement] public uint Refinement { get; protected set; } = 0;

        [BsonIgnore] public uint WeaponEntityId;
        [BsonIgnore] public new WeaponData ItemData => (WeaponData)GameData.ItemDataMap[ItemId];
        [BsonIgnore] public WeaponPromoteData PromoteData => GameData.WeaponPromoteDataMap[Tuple.Create(ItemData.weaponPromoteId, PromoteLevel)];

        public WeaponItem(ulong guid, uint itemId, uint uniqueId, uint level = 1, uint refinement = 0) : base(guid, itemId)
        {
            Id = uniqueId;
            Refinement = refinement;
            Level = level;
            PromoteLevel = GetMinPromoteLevel(Level);
            
            if (ItemData.skillAffix != null)
            {
                foreach (int skillAffix in ItemData.skillAffix)
                {
                    if (skillAffix > 0)
                    {
                        Affixes.Add(skillAffix);
                    }
                }
            }
        }

        public async Task OnLoadAsync(ulong guid)
        {
            Guid = guid;
            Count = 1;
        }


        public Shared.Network.Proto.Weapon ToWeaponProto()
        {
            Shared.Network.Proto.Weapon weapon = new()
            {
                Level = (uint)Level,
                Exp = (uint)Exp,
                PromoteLevel = (uint)PromoteLevel
            };


            if (Affixes != null && Affixes.Count > 0)
            {
                foreach (int affix in Affixes)
                {
                    weapon.AffixMap.Add((uint)affix, (uint)Refinement);
                }
            }

            return weapon;
        }

        public SceneWeaponInfo CreateSceneWeaponInfo()
        {
            SceneWeaponInfo weaponInfo = new SceneWeaponInfo()
            {
                EntityId = WeaponEntityId,
                ItemId = (uint)ItemId,
                Guid = Guid,
                Level = (uint)Level,
                GadgetId = (uint)ItemData.gadgetId,
                AbilityInfo = new AbilitySyncStateInfo() { IsInited = Affixes.Count > 0 }
            };

            if (Affixes.Count > 0)
            {
                foreach (int affix in Affixes)
                {
                    weaponInfo.AffixMap.Add((uint)affix, (uint)Refinement);
                }
            }

            return weaponInfo;
        }

        public override Item ToProto()
        {
            Item proto = new()
            {
                Guid = Guid,
                ItemId = (uint)ItemData.id
            };

            Shared.Network.Proto.Weapon weapon = ToWeaponProto();
            proto.Equip = new Equip() { Weapon = weapon, IsLocked = Locked };
            return proto;
        }
    }
}
