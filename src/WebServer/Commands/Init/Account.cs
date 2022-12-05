using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.Shared.Commands;
using Weedwacker.Shared.Enums;

namespace Weedwacker.WebServer.Commands
{
    internal partial class WebServerCommands
    {
        static void CreateAccount()
        {
            #region add account create command
            var passwordOption = new Option<string>(
                name: "-p",
                description: "accont's password");

            var uidOption = new Option<string>(
                name: "-u",
                description: "account's uid", getDefaultValue: () => "0");

            var nameArgument = new Argument<string>(name: "username");

            Command accountCommand = new ("account", "Account related operations") { };
            Command createCommand = new ("create", "Create an account") { };

            createCommand.AddAlias("add");
            createCommand.AddArgument(nameArgument);
            createCommand.AddOption(uidOption);
            createCommand.AddOption(passwordOption);

            createCommand.SetHandler(ConsoleCommands.CreateAccount,UserRank.Console, nameArgument, uidOption, passwordOption);

            accountCommand.AddCommand(createCommand);

            ConsoleHandler.AddCommand(accountCommand);

            #endregion
        }
    }
}
