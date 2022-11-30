using Weedwacker.Shared.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.Shared.Commands
{
    public static partial class ConsoleHandler
    {
        static readonly Dictionary<string, (byte, UserRank, Func<string[], Task<string>>, byte)> RegisteredCommands = new()
        {
            { "help", (0, UserRank.Mod, ConsoleCommands.OnHelp, 0) },
            { "hashability", (1, UserRank.Console, ConsoleCommands.OnHashAbility, 1) },
            { "hashpath", (1, UserRank.Console, ConsoleCommands.OnHashPath, 1) }
        };
        public static void AddCommand(string cmd, byte argCount, UserRank rank, Func<string[], Task<string>> action, byte minArgCount = default)
        {
            if (minArgCount == default) minArgCount = argCount;
            RegisteredCommands[cmd] = (argCount, rank, action, minArgCount);
        }
        public static async Task Start()
        {
            Start:
            try
            {
            CommandHandler:
                string cmd = ParseCommandString(Console.ReadLine(), out string[] args);
                Logger.WriteLine(await ExecuteCommand(cmd, UserRank.Console, args));
                goto CommandHandler;
            }
            catch (Exception e)
            {
                Logger.WriteErrorLine(e.ToString());
            }
            goto Start;
        }
        static bool CheckCommandArguments(params string[] args) => !args.Any(arg => string.IsNullOrEmpty(arg) || string.IsNullOrWhiteSpace(arg));
        public static async Task<string> ExecuteCommand(string cmd, UserRank reqRank, params string[] args)
        {
            if (!RegisteredCommands.TryGetValue(cmd, out var com))
                return "Invalid command";
            byte argCount = com.Item1;
            byte minArgCount = com.Item4;
            UserRank requiredRank = com.Item2;
            if (argCount > 0 && (args == null || args.Length > argCount || !CheckCommandArguments(args)) // check if user passed more arguments than the command allows
                || args.Length < minArgCount) // check if user passed less arguments than the minimum needed
                return "Invalid arguments";
            if (requiredRank > reqRank)
                return "Not enough privileges";
            if (com.Item3 == null)
                return "Command does not exists";
            return await com.Item3(args);
        }
        public static string ParseCommandString(string? input, out string[] args)
        {
            args = Array.Empty<string>();
            if (string.IsNullOrEmpty(input))
                return string.Empty;
            if (!input.Contains(' '))
                return input;
            args = input.Split(' ');
            if (args.Length <= 0)
                return string.Empty;
            string cmd = args[0].ToLower();
            args = args.Skip(1).ToArray();
            if (input.Contains('\"'))
            {
                List<string> finalArgs = new();
                string tmp = string.Empty;
                short idx = -1;
                for (short i = 0; i < args.Length; i++)
                {
                    if (idx < 0)
                    {
                        if (args[i].StartsWith("\"") && !args[i].EndsWith("\""))
                        {
                            idx = i;
                            tmp = $"{args[i]} ";
                            continue;
                        }
                    }
                    else
                    {
                        if (args[i].EndsWith("\""))
                        {
                            tmp += args[i];
                            finalArgs.Add(tmp.Replace("\"", string.Empty));
                            tmp = string.Empty;
                            idx = -1;
                        }
                        else
                            tmp += $"{args[i]} ";
                        continue;
                    }
                    finalArgs.Add(args[i]);
                }
                if (idx < 0)
                    args = finalArgs.ToArray();
            }
            return cmd;
        }
    }
}
