using System.CommandLine;
using Weedwacker.GameServer;
using Weedwacker.GameServer.Commands;
using Weedwacker.Shared.Commands;

await GameServer.Start();


//ConsoleHandler.AddCommand("addavatar", 2, Weedwacker.Shared.Enums.UserRank.Player, Weedwacker.GameServer.Commands.ConsoleCommands.OnAddAvatar);
//ConsoleHandler.AddCommand("openstate", 2, Weedwacker.Shared.Enums.UserRank.Player, Weedwacker.GameServer.Commands.ConsoleCommands.OnOpenState);
//ConsoleHandler.AddCommand("spawn", 2, Weedwacker.Shared.Enums.UserRank.Player, Weedwacker.GameServer.Commands.ConsoleCommands.OnSpawn);
//ConsoleHandler.AddCommand("exporthashes", 0, Weedwacker.Shared.Enums.UserRank.Console, Weedwacker.GameServer.Commands.ConsoleCommands.OnExportHashes);
//ConsoleHandler.AddCommand("give", 5, Weedwacker.Shared.Enums.UserRank.Player, Weedwacker.GameServer.Commands.ConsoleCommands.OnGive, 2);

// general arguments
var guidArgument = new Argument<int>(name: "uid");
var idArgument = new Argument<int>(name: "id");

# region addavatar command

var AvatarIdArgument = new Argument<int>(name: "AvatarId");

Command AddavatarCommand = new Command("addavatar", "Add avatar to player") { };

AddavatarCommand.SetHandler(Weedwacker.GameServer.Commands.ConsoleCommands.OnAddAvatar, AvatarIdArgument, guidArgument);
AddavatarCommand.AddArgument(guidArgument);
AddavatarCommand.AddArgument(AvatarIdArgument);

ConsoleHandler.AddCommand(AddavatarCommand);

#endregion

# region openstate command


var OpenStateArgument = new Argument<int>(name: "OpenState");

Command OpenStateCommand = new Command("openstate", "Set openstate for player");
OpenStateCommand.AddArgument(guidArgument);

OpenStateCommand.AddArgument(OpenStateArgument);

OpenStateCommand.SetHandler(Weedwacker.GameServer.Commands.ConsoleCommands.OnOpenState, OpenStateArgument, guidArgument);


ConsoleHandler.AddCommand(OpenStateCommand);

#endregion

# region spawn command

Command spawnCommand = new Command("spawn", "spawn entity {id} for player");

spawnCommand.SetHandler(Weedwacker.GameServer.Commands.ConsoleCommands.OnSpawn, guidArgument, idArgument);
spawnCommand.AddArgument(guidArgument);
spawnCommand.AddArgument(idArgument);

ConsoleHandler.AddCommand(spawnCommand);

#endregion

# region exporthashes command

Command exporthashesCommand = new Command("exporthashes", "exported ability hashes");

exporthashesCommand.SetHandler(Weedwacker.GameServer.Commands.ConsoleCommands.OnExportHashes);

ConsoleHandler.AddCommand(exporthashesCommand);

#endregion

# region give command

Option<int> countOption = new(name:"-c",description:"count",getDefaultValue:()=>1);
Option<int> levelOption = new(name:"-l",description:"level",getDefaultValue:()=>1);
Option<int> refinementOption = new(name:"-r",description: "refinement", getDefaultValue:()=>1);

Command giveCommand = new Command("give", "Added item to player");

giveCommand.SetHandler(Weedwacker.GameServer.Commands.ConsoleCommands.OnGive,
    guidArgument,idArgument,countOption,levelOption,refinementOption);

giveCommand.AddArgument(guidArgument);
giveCommand.AddArgument(idArgument);
giveCommand.AddOption(countOption);
giveCommand.AddOption(levelOption);
giveCommand.AddOption(refinementOption);
ConsoleHandler.AddCommand(giveCommand);

#endregion

ConsoleHandler.Start();
await ConsoleHandler.Start();