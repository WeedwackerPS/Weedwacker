using System.CommandLine;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Systems.World;

namespace Weedwacker.GameServer.Commands
{
    public static partial class ConsoleCommands
    {
        public static async Task OnSpawn(IConsole console, int guid, int id) // GameUid, id
        {
            if (!GameServer.OnlinePlayers.ContainsKey((uint)guid))
            {
                Console.WriteLine("Player isn't online or doesn't exist");
                return ;
            }
            var scene = GameServer.OnlinePlayers[(uint)guid].Player.Scene;

            if (GameData.MonsterDataMap.ContainsKey((uint)id))
            {
                await scene.AddEntityAsync(await MonsterEntity.CreateAsync(scene, GameServer.OnlinePlayers[(uint)guid].Player, GameData.MonsterDataMap[(uint)id], 3));
            }
            else if (GameData.GadgetDataMap.ContainsKey((uint)id))
            {
                //await scene.AddEntityAsync(new BaseGadgetEntity(scene, id));
            }
            else if (GameData.ItemDataMap.ContainsKey((uint)id))
            {
                await scene.AddEntityAsync(await ItemEntity.CreateAsync(scene, GameServer.OnlinePlayers[(uint)guid].Player, GameData.ItemDataMap[(uint)id], GameServer.OnlinePlayers[(uint)guid].Player.Position, 1));
            }
            else
                goto ERROR;
            console.WriteLine($"spawn entity {id} for player {guid}");
            return ;
        ERROR:
            console.WriteLine($"could not find entity {id}");
            return ;
        }
    }
}
