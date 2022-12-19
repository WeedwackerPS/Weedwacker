using Weedwacker.GameServer;
using Weedwacker.GameServer.Commands;
using Weedwacker.GameServer.Packet.Recorder;
using Weedwacker.Shared.Commands;

await GameServer.Start();

GameServerCommands.InitAll();

await ConsoleHandler.Start();