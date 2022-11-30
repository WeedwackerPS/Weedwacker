
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Commands
{
    public static partial class ConsoleCommands
    {
        public static async Task<string> OnGive(params string[] args) // GameUid, itemID, count, level, refinement
        {
            if (!int.TryParse(args[0], out int guid) ||
                !GameServer.OnlinePlayers.ContainsKey(guid))
            {
                return "Player isn't online or doesn't exist";
            }
            if (!int.TryParse(args[1], out int itemId) || !GameData.ItemDataMap.ContainsKey(itemId))
            {
                return "invalid item id";
            }
            int count = 1;
            int lvl = 1;
            int refinement = 1;
            if (args.Length >= 3 && !int.TryParse(args[2], out count))
            {
                return "invalid amount";
            }
            if (args.Length >= 4 && (!int.TryParse(args[3], out lvl) || lvl < 1 || lvl > 90))
            {
                return "invalid level";
            }
            if (args.Length >= 5 && (!int.TryParse(args[4], out refinement) || refinement < 1 || refinement > 5))
            {
                return "invalid refinement";
            }
            if (GameData.ItemDataMap[itemId].itemType == ItemType.ITEM_RELIQUARY || GameData.ItemDataMap[itemId].itemType == ItemType.ITEM_WEAPON)
            {
                for (int i = 0; i < count; i++)
                {
                    await GameServer.OnlinePlayers[guid].Player.Inventory.AddItemByIdAsync(itemId, 1, ActionReason.None, true, lvl, refinement - 1); //convert refinement to code value
                }   
            }
            else
            {
                await GameServer.OnlinePlayers[guid].Player.Inventory.AddItemByIdAsync(itemId, count, ActionReason.None, true);
            }
            
            return $"Added {count} item {itemId} to player {guid} at level {lvl} and refinement {refinement}";
        }
    }
}
