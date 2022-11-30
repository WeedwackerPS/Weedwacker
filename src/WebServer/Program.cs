using Weedwacker.Shared.Commands;
using Weedwacker.WebServer;

WebServer.Start();
ConsoleHandler.AddCommand("createaccount", 2, Weedwacker.Shared.Enums.UserRank.Console, Weedwacker.WebServer.Commands.ConsoleCommands.OnCreateAccount, 1);
await ConsoleHandler.Start();