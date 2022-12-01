using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.Shared.Commands;

namespace Weedwacker.GameServer.Commands
{
    internal partial class GameServerCommands
    {
        static void Spawn()
        {

            #region spawn command

            Command spawnCommand = new Command("spawn", "spawn entity {id} for player");

            spawnCommand.SetHandler(Weedwacker.GameServer.Commands.ConsoleCommands.OnSpawn, guidArgument, idArgument);
            spawnCommand.AddArgument(guidArgument);
            spawnCommand.AddArgument(idArgument);

            ConsoleHandler.AddCommand(spawnCommand);

            #endregion
        }
    }
}
