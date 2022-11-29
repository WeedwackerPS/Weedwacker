using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.GameServer.Systems.Player;

namespace Weedwacker.GameServer.Commands
{
    public static partial class ConsoleCommands
    {
        public static async Task<string> OnAddAvatar(params string[] args) // AvatarId, GameUid
        {
            string usage = "Usage: /addavatar (AvatarId) (uid)"; //TODO: Send usage instead of "Invalid Arguments" everytime

            if (!int.TryParse(args[0], out int avatarId) ||
                !GameServer.AvatarInfo.ContainsKey(avatarId))
            {
                return "invalid avatar id";
            }
            if (!int.TryParse(args[1], out int guid) ||
                !GameServer.OnlinePlayers.ContainsKey(guid))
            {
                return "Player isn't online or doesn't exist";
            }
            Player player = GameServer.OnlinePlayers[guid].Player;
            if (player.Avatars.HasAvatar(int.Parse(args[0])))

            {
                return "You already have that avatar!";
            }

            var newAvatar = await Avatar.CreateAsync(avatarId, GameServer.OnlinePlayers[guid].Player);
            await player.Avatars.AddAvatar(newAvatar);
            return $"Added avatar {avatarId} to player {guid}";
        }
    }
}
