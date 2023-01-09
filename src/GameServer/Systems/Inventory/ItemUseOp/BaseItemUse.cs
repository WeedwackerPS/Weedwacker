using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;

namespace Weedwacker.GameServer.Systems.Inventory.ItemUseOp
{
    internal abstract class BaseItemUse
    {
        protected Player.Player User;
        protected MaterialData ItemData;

        public BaseItemUse(Player.Player user, uint itemId)
        {
            User = user;
            ItemData = (MaterialData)GameData.ItemDataMap[itemId];
        }
        internal abstract Task<bool> Use();
    }
}
