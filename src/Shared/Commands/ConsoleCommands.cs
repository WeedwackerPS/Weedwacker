using System.CommandLine;

namespace Weedwacker.Shared.Commands
{
    public static partial class ConsoleCommands
    {
        [RequiredRank(UserRank.Console)]
        public static async Task OnHashAbility(IConsole console,string arg)
        {
            await Task.Yield();
            console.WriteLine( Utils.Utils.AbilityHash(arg).ToString());
        }

        [RequiredRank(UserRank.Console)]
        public static async Task OnHashPath(IConsole console,string args)
        {
            await Task.Yield();
            console.WriteLine(Utils.Utils.GetPathHash(args[0].ToString()).ToString());
        }
    }
}
