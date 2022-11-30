using Weedwacker.GameServer;
using Weedwacker.Shared.Commands;

await GameServer.Start();
ConsoleHandler.AddCommand("addavatar", 2, Weedwacker.Shared.Enums.UserRank.Player, Weedwacker.GameServer.Commands.ConsoleCommands.OnAddAvatar);
ConsoleHandler.AddCommand("openstate", 2, Weedwacker.Shared.Enums.UserRank.Player, Weedwacker.GameServer.Commands.ConsoleCommands.OnOpenState);
ConsoleHandler.AddCommand("spawn", 2, Weedwacker.Shared.Enums.UserRank.Player, Weedwacker.GameServer.Commands.ConsoleCommands.OnSpawn);
ConsoleHandler.AddCommand("exporthashes", 0, Weedwacker.Shared.Enums.UserRank.Console, Weedwacker.GameServer.Commands.ConsoleCommands.OnExportHashes);
ConsoleHandler.AddCommand("give", 5, Weedwacker.Shared.Enums.UserRank.Player, Weedwacker.GameServer.Commands.ConsoleCommands.OnGive, 2);
await ConsoleHandler.Start();