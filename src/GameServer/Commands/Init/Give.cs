using System.CommandLine;
using Weedwacker.Shared.Commands;
using Weedwacker.Shared.Enums;

namespace Weedwacker.GameServer.Commands
{
    internal static partial class GameServerCommands
    {
        static void Give()
        {
            #region give command

            Option<int> countOption = new(name: "-c", description: "count", getDefaultValue: () => 1);
            Option<int> levelOption = new(name: "-l", description: "level", getDefaultValue: () => 1);
            Option<int> refinementOption = new(name: "-r", description: "refinement", getDefaultValue: () => 1);

            Command giveCommand = new Command("give", "Added item to player");

            giveCommand.SetHandler(ConsoleCommands.OnGive, UserRank.Player,
                guidArgument, idArgument, countOption, levelOption, refinementOption);

            giveCommand.AddArgument(guidArgument);
            giveCommand.AddArgument(idArgument);
            giveCommand.AddOption(countOption);
            giveCommand.AddOption(levelOption);
            giveCommand.AddOption(refinementOption);
            ConsoleHandler.AddCommand(giveCommand);

            #endregion
        }
    }
}
