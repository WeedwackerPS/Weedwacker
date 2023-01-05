using System.Numerics;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Inventory;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.World
{
    internal class ItemEntity : BaseGadgetEntity
    {
        public readonly ItemData ItemData;
        public readonly int Count;
        public readonly ulong Guid;
        private readonly GameItem Item; // DO NOT use to store in the inventory, just to have easy access to GameItem::ToProto

        public readonly bool Share;

        // In official game, some drop items are shared to all players, and some other items are independent to all players
        // For example, if you killed a monster in MP mode, all players could get drops but rarity and number of them are different
        // but if you broke regional mine, when someone picked up the drop then it disappeared
        public ItemEntity(Scene scene, Player.Player? player, ItemData itemData, Vector3 pos, int count, bool share = true) : base(scene)
        {
            EntityId = Scene.World.GetNextEntityId(EntityIdType.GADGET);
            Position = pos;
            Guid = player == null ? scene.World.Host.GetNextGameGuid() : player.GetNextGameGuid();
            ItemData = itemData;
            Count = count;
            Share = share;
            // Maybe subclass weapons and relics as materials?
            if (itemData is MaterialData material)
            {
                GadgetId = material.gadgetId;
                Item = new MaterialItem(Guid, itemData.id, count);
            }
            else if (itemData is WeaponData weapon)
            {
                GadgetId = weapon.gadgetId;
                Item = new WeaponItem(Guid, itemData.id, 0);
            }
            else if (itemData is ReliquaryData relic)
            {
                GadgetId = relic.gadgetId;
                Item = new ReliquaryItem(Guid, itemData.id, 0);
            }
            else Logger.WriteErrorLine("invalid drop item: " + itemData.id);
        }

        public override async Task OnInteractAsync(Player.Player player, GadgetInteractReq interactReq)
        {
            // check drop owner to avoid someone picked up item in others' world
            if (!Share)
            {
                int dropOwner = (int)(Guid >> 32);
                if (dropOwner != player.GameUid)
                {
                    return;
                }
            }

            await Scene.RemoveEntityAsync(this);

            // Add to inventory
            await player.Inventory.AddItemByIdAsync(ItemData.id, Count, ActionReason.SubfieldDrop);
        }


        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            info.Gadget.BornType = GadgetBornType.InAir;
            info.Gadget.TrifleItem = Item.ToProto();

            return info;
        }
    }
}
