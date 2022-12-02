using System.CommandLine;
using Weedwacker.GameServer;
using Weedwacker.GameServer.Commands;
using Weedwacker.Shared.Commands;

await GameServer.Start();

GameServerCommands.InitAll();

await ConsoleHandler.Start();