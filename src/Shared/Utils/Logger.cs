using System.Runtime.CompilerServices;

namespace Weedwacker.Shared.Utils
{
    public static class Logger
    {
        public static void WriteLine(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string fileName = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            Console.WriteLine(ParseMessage(message, memberName, fileName, lineNumber));
        }
        private static string ParseMessage(string message, string memberName = "", string fileName = "",
            int lineNumber = 0)
        {
            return $"[{DateTime.UtcNow:yy-MM-dd HH:mm:ss}]<{fileName.Split("\\").Last()}:{memberName}> {message}";
        }
        public static void DebugWriteLine(string message)
        {
#if DEBUG
            Console.WriteLine(ParseMessage(message));
#endif
        }

        public static void DebugWriteWarningLine(string message)
        {
#if DEBUG
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(ParseMessage(message));
            Console.ResetColor();
#endif
        }
        public static void WriteErrorLine(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string fileName = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Error.WriteLine(ParseMessage(message, memberName, fileName,
            lineNumber));
            Console.ResetColor();
        }

        public static void WriteErrorLine(string message, Exception e, [CallerMemberName] string memberName = "", [CallerFilePath] string fileName = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            WriteErrorLine(message, memberName, fileName,
            lineNumber);
            WriteErrorLine(e.StackTrace);
        }
    }
}