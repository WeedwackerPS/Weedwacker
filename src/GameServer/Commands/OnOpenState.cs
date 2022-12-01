using System.CommandLine;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Commands
{
    public static partial class ConsoleCommands
    {
        [RequiredRank(UserRank.Player)]
        public static async Task OnOpenState(IConsole console, int openState,int guid) // OpenState, GameUid
        {
            if (!Enum.IsDefined(typeof(OpenStateType), openState))
            {
                console.WriteLine("invalid openstate id");
                return ;
            }
            if (!GameServer.OnlinePlayers.ContainsKey(guid))
            {
                console.WriteLine("Player isn't online or doesn't exist");
                return ;
            }
            await GameServer.OnlinePlayers[guid].Player.OpenStateManager.SetOpenStateAsync(openState, 1);
            console.WriteLine($"Set openstate {openState} for player {guid}");
        }
    }
}
