using System.CommandLine;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.GameServer.Systems.Player;

namespace Weedwacker.GameServer.Commands
{
    public static partial class ConsoleCommands
    {
        [RequiredRank(UserRank.Player)]
        public static async Task OnAddAvatar(IConsole console,int avatarId, int guid) // AvatarId, GameUid
        {
            if (!GameServer.AvatarInfo.ContainsKey(avatarId))
            {
                console.WriteLine( "Invalid avatar id");
                return;
            }
            if (!GameServer.OnlinePlayers.ContainsKey(guid))
            {
                console.WriteLine("Player isn't online or doesn't exist");
                return;
            }
            Player player = GameServer.OnlinePlayers[guid].Player;

            if (player.Avatars.HasAvatar(avatarId))
            {
                console.WriteLine ("You already have that avatar!");
                return;
            }

            var newAvatar = await Avatar.CreateAsync(avatarId, GameServer.OnlinePlayers[guid].Player);
            await player.Avatars.AddAvatar(newAvatar);
            console.WriteLine($"Added avatar {avatarId} to player {guid}");
        }
    }
}
