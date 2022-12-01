using System.CommandLine;
using Weedwacker.Shared.Commands;
using Weedwacker.WebServer;
using Weedwacker.WebServer.Commands;

WebServer.Start();



WebServerCommands.InitAll();

ConsoleHandler.Start();

await ConsoleHandler.Start();