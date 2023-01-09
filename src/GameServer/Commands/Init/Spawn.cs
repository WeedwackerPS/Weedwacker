using System.CommandLine;
using Weedwacker.Shared.Commands;
using Weedwacker.Shared.Enums;

namespace Weedwacker.GameServer.Commands
{
    internal partial class GameServerCommands
    {
        static void Spawn()
        {

            #region spawn command

            Command spawnCommand = new Command("spawn", "spawn entity {id} for player");

            spawnCommand.SetHandler(ConsoleCommands.OnSpawn, UserRank.Player, guidArgument, idArgument);
            spawnCommand.AddArgument(guidArgument);
            spawnCommand.AddArgument(idArgument);

            ConsoleHandler.AddCommand(spawnCommand);

            #endregion
        }
    }
}
