using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.WebServer.Database;

namespace Weedwacker.WebServer.Commands
{
    public partial class ConsoleCommands
    {
        // account
        [RequiredRank(UserRank.Console)]
        public static async Task CreateAccount(IConsole con, string name, string uid,string pwd)
        {
            if (string.IsNullOrEmpty(name))
            {
                con.WriteLine($"Username is invalid");
                return;
            }
            Account? account = await DatabaseManager.GetAccountByNameAsync(name);
            if (account != null)
            {
                con.WriteLine($"Username {name} already exists!");
            }
            else
            {
                DatabaseManager.CreateAccountWithUid(username:name,password:pwd,uid:uid);

                con.WriteLine($"successfully created account {name}");
            }
        }
    }
}
