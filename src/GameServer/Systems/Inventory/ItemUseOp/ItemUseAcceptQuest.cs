namespace Weedwacker.GameServer.Systems.Inventory.ItemUseOp
{
    [ItemUse(Enums.ItemUseOp.ITEM_USE_ACCEPT_QUEST)]
    internal class ItemUseAcceptQuest : BaseItemUse
    {
        public ItemUseAcceptQuest(Player.Player user, uint itemId) : base(user, itemId)
        {
        }

        internal override Task<bool> Use()
        {
            throw new NotImplementedException();
        }
    }
}
