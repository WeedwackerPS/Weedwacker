using MongoDB.Bson.Serialization.Attributes;

namespace Weedwacker.GameServer.Systems.Inventory
{
    [BsonKnownTypes(typeof(WeaponItem), typeof(ReliquaryItem))]
    internal abstract class EquipItem : GameItem
    {
        // Equips
        public virtual int Level { get; set; }
        public virtual int Exp { get; set; }
        public virtual int TotalExp { get; set; }
        public virtual int PromoteLevel { get; set; }
        public bool Locked { get; protected set; }
        public int EquippedAvatar = 0; // AvatarId

        protected EquipItem(ulong guid, int itemId) : base(guid, itemId, 1)
        {
        }
        public static int GetMinPromoteLevel(int level)
        {
            if (level > 80)
            {
                return 6;
            }
            else if (level > 70)
            {
                return 5;
            }
            else if (level > 60)
            {
                return 4;
            }
            else if (level > 50)
            {
                return 3;
            }
            else if (level > 40)
            {
                return 2;
            }
            else if (level > 20)
            {
                return 1;
            }
            return 0;
        }
    }
}
