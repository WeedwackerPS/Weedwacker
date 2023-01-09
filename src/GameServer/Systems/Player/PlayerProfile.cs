using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Player
{

    public class PlayerProfile
    {
        public uint NameCardId = 210001;
        public string Nickname;
        public uint Level = 1;
        public uint WorldLevel = 1;
        public Birthday Birthday = new() { Day = 0, Month = 0 }; // <Day,Month>
        public ProfilePicture? HeadImage; // <avatarId, skinId>
        public string? HeroName;
        public string? Signature = "";
        public uint Achievements;
        public uint DaysSinceLastLogin;
        public int LastActiveTime;
        public uint[]? BlacklistUidList;

        public PlayerProfile(string heroName)
        {
            HeroName = heroName;
            Nickname = heroName;
        }
    }

}
