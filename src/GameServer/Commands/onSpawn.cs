using System.CommandLine;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Systems.World;

namespace Weedwacker.GameServer.Commands
{
    public static partial class ConsoleCommands
    {
        public static async Task OnSpawn(IConsole console, int guid, int id) // GameUid, id
        {
            if (!GameServer.OnlinePlayers.ContainsKey(guid))
            {
                Console.WriteLine("Player isn't online or doesn't exist");
                return ;
            }
            var scene = GameServer.OnlinePlayers[guid].Player.Scene;

            if (GameData.MonsterDataMap.ContainsKey(id))
            {
                await scene.AddEntityAsync(await MonsterEntity.CreateAsync(scene, GameServer.OnlinePlayers[guid].Player, GameData.MonsterDataMap[id], 3));
            }
            else if (GameData.GadgetDataMap.ContainsKey(id))
            {
                //await scene.AddEntityAsync(new BaseGadgetEntity(scene, id));
            }
            else if (GameData.ItemDataMap.ContainsKey(id))
            {
                await scene.AddEntityAsync(new ItemEntity(scene, GameServer.OnlinePlayers[guid].Player, GameData.ItemDataMap[id], GameServer.OnlinePlayers[guid].Player.Position, 1));
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
