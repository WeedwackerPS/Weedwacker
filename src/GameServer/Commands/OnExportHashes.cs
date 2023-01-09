using Newtonsoft.Json;
using System.CommandLine;

namespace Weedwacker.GameServer.Commands
{
    public static partial class ConsoleCommands
    {
        public static async Task OnExportHashes(IConsole console)
        {
            string jsonString = JsonConvert.SerializeObject(GameServer.AbilityNameHashMap, Formatting.Indented);
            await File.WriteAllTextAsync("ability_hashMap.json", jsonString);

            console.WriteLine($"exported ability hashes") ;
        }
    }
}
