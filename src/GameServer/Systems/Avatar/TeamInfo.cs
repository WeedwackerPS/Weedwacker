using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Avatar
{
    internal class TeamInfo
    {
        private TeamManager Manager;
        public string TeamName;
        [BsonSerializer(typeof(IntSortedListSerializer<Avatar>))]
        [BsonElement] public SortedList<int, Avatar?> AvatarInfo { get; private set; } = new(); // <index, avatar>> clone avatars for abyss teams
        public HashSet<TeamResonanceData> TeamResonances = new();
        internal Dictionary<string, Dictionary<string, float>?>? AbilitySpecials = new(); // <abilityName, <abilitySpecial, value>>

        [BsonElement] public bool IsTowerTeam { get; private set; } = false; //Don't allow any further team editing if it's an abyss team
        public TeamInfo(string name = "")
        {
            TeamName = name;
            for (int i = 0; i < GameServer.Configuration.Server.GameOptions.AvatarLimits.SinglePlayerTeam; i++)
            {
                AvatarInfo[i] = null;
            }
        }

        public TeamInfo(IEnumerable<Avatar> avatars, string name = "", bool isTowerTeam = false)
        {
            TeamName = name;
            IsTowerTeam = false;
            int index = 0;
            foreach (var item in avatars)
            {
                AddAvatar(item,index);
                index++;
            }
            IsTowerTeam = isTowerTeam;
        }

        public async Task OnLoadAsync(Player.Player owner)
        {
            AvatarInfo.Values.AsParallel().ForAll(async w => await w.OnLoadAsync(owner)); // hope same avatar with different guid doesnt break anything...
            AbilitySpecials = new();
        }


        public bool AddAvatar(Avatar avatar, int index = 0)
        {
            if (IsTowerTeam || AvatarInfo.ContainsValue(avatar) || index > GameServer.Configuration.Server.GameOptions.AvatarLimits.SinglePlayerTeam)
            {
                return false;
            }

            AvatarInfo[index] = IsTowerTeam ? avatar.Clone() : avatar;

            UpdateTeamResonances();

            return true;
        }

        private ushort GetAvatarNumElement(Enums.ElementType element)
        {
            ushort num = 0;
            foreach (var avatar in AvatarInfo.Values)
            {
                if (avatar == null || avatar.GetCurSkillDepot().Element == null) continue;
                if (avatar.GetCurSkillDepot().Element.Type == element)
                    num++;
            }
            return num;
        }

        public bool RemoveAvatar(int slot)
        {
            if (IsTowerTeam || slot >= AvatarInfo.Count)
            {
                return false;
            }

            AvatarInfo.RemoveAt(slot);
            UpdateTeamResonances();

            return true;
        }

        private void UpdateTeamResonances()
        {
            TeamResonances.Clear();
            foreach (var entry in GameData.TeamResonanceDataMap.Values)
            {
                bool shouldApply = false;
                if (entry.cond != null && entry.cond != "")
                {
                    if (entry.cond == "TEAM_RESONANCE_COND_ALL_DIFFERENT")
                    {
                        foreach (Enums.ElementType type in Enum.GetValues(typeof(Enums.ElementType)))
                        {
                            if (GetAvatarNumElement(type) >= 1)
                            {
                                shouldApply = false;
                                break;
                            }
                        }
                    }
                }
                if (entry.fireAvatarCount != null)
                {
                    shouldApply = shouldApply | entry.fireAvatarCount <= GetAvatarNumElement(Enums.ElementType.Fire);
                }
                if (entry.waterAvatarCount != null)
                {
                    shouldApply = shouldApply | entry.waterAvatarCount <= GetAvatarNumElement(Enums.ElementType.Water);
                }
                if (entry.windAvatarCount != null)
                {
                    shouldApply = shouldApply | entry.windAvatarCount <= GetAvatarNumElement(Enums.ElementType.Wind);
                }
                if (entry.electricAvatarCount != null)
                {
                    shouldApply = shouldApply | entry.electricAvatarCount <= GetAvatarNumElement(Enums.ElementType.Electric);
                }
                if (entry.grassAvatarCount != null)
                {
                    shouldApply = shouldApply | entry.grassAvatarCount <= GetAvatarNumElement(Enums.ElementType.Grass);
                }
                if (entry.iceAvatarCount != null)
                {
                    shouldApply = shouldApply | entry.iceAvatarCount <= GetAvatarNumElement(Enums.ElementType.Ice);
                }
                if (entry.rockAvatarCount != null)
                {
                    shouldApply = shouldApply | entry.rockAvatarCount <= GetAvatarNumElement(Enums.ElementType.Fire);
                }

                if (shouldApply)
                    TeamResonances.Add(entry);
            }
        }
        public void CopyFrom(TeamInfo team)
        {
            CopyFrom(team, GameServer.Configuration.Server.GameOptions.AvatarLimits.SinglePlayerTeam);
        }

        public bool CopyFrom(TeamInfo team, int maxTeamSize)
        {
            if (IsTowerTeam || team.AvatarInfo.Count > maxTeamSize) return false;
            AvatarInfo = (SortedList<int, Avatar?>)team.MemberwiseClone();
            return true;
        }

        public AvatarTeam ToProto(Player.Player player)
        {
            AvatarTeam avatarTeam = new AvatarTeam()
            {
                TeamName = TeamName
            };

            foreach (var entry in AvatarInfo)
            {
                if (entry.Value != null)
                    avatarTeam.AvatarGuidList.Add(entry.Value.Guid);
            }

            return avatarTeam;
        }
    }
}
