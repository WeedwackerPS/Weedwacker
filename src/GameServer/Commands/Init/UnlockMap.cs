using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.Shared.Commands;
using Weedwacker.Shared.Enums;

namespace Weedwacker.GameServer.Commands
{
    internal static partial class GameServerCommands
    {
        static void UnlockMap()
        {
            #region unlockMap command

            Command unlockMapCommand = new Command("unlockMap", "Unlock Player Maps And Points");

            unlockMapCommand.SetHandler(ConsoleCommands.unlockMap, UserRank.Player,guidArgument);

            unlockMapCommand.AddArgument(guidArgument);
            ConsoleHandler.AddCommand(unlockMapCommand);

            #endregion
        }
    }
}
