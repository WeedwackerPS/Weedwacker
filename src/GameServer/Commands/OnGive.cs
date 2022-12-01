
using System.CommandLine;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Commands
{
    public static partial class ConsoleCommands
    {
        [RequiredRank(UserRank.Player)]
        public static async Task OnGive(IConsole console,
            int guid,int itemId,int count,int lvl, int refinement) // GameUid, itemID, count, level, refinement
        {
            if (!GameServer.OnlinePlayers.ContainsKey(guid))
            {
                console.WriteLine("Player isn't online or doesn't exist");
                return;
            }
            if (!GameData.ItemDataMap.ContainsKey(itemId))
            {
                console.WriteLine("invalid item id");
                return;
            }

            if (count<1)
            {
                count = 1;
            }

            if (lvl < 1 || lvl > 90)
            {
                console.WriteLine("invalid level");
                return;
            }
            if ( refinement < 1 || refinement > 5)
            {
                console.WriteLine("invalid refinement");
                return;
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
            console.WriteLine($"Added {count} item {itemId} to player {guid} at level {lvl} and refinement {refinement}");
            return;
        }
    }
}
