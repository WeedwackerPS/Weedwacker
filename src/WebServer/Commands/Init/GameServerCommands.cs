using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.Shared.Commands;

namespace Weedwacker.WebServer.Commands
{
    internal partial class WebServerCommands
    {
        // general arguments
        private static Argument<int> guidArgument = new Argument<int>(name: "uid");
        private static Argument<int> idArgument = new Argument<int>(name: "id");


        public static void InitAll()
        {
            ConsoleHandler.Init();

            CreateAccount();
        }


    }
}
