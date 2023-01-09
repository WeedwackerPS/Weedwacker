using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.Ability;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class TeamManager : BaseEntity
    {
        [BsonId] public uint OwnerId;
        private Player Owner;
        [BsonSerializer(typeof(IntSortedListSerializer<TeamInfo>))]
        [BsonElement] public SortedList<int, TeamInfo> Teams { get; private set; } = new(); // <index, team>
        [BsonSerializer(typeof(IntSortedListSerializer<TeamInfo>))]
        [BsonElement] public SortedList<int, TeamInfo> TowerTeams { get; private set; } = new(); // Store Abyss teams separately
        [BsonIgnore] public TeamInfo MpTeam = new();
        [BsonElement] public int CurrentTeamIndex { get; private set; } = 1; // count from  1
        public int CurrentCharacterIndex = 0; // count from 0
        [BsonIgnore] public SortedList<int, AvatarEntity> ActiveTeam = new(); // index

        [BsonIgnore] public AbilitySyncStateInfo AbilitySyncState = new(); //TODO
        [BsonIgnore] public ulong CurrentCharacterGuid => CurrentAvatarEntity.Avatar.Guid;

        [BsonIgnore] public TeamInfo CurrentTeamInfo
        {
            get
            {
                if (Owner.IsInMultiplayer)
                    return MpTeam;
                else
                    return Teams[CurrentTeamIndex];
            }
        }

        [BsonIgnore] public TeamInfo CurrentSinglePlayerTeamInfo => Teams[CurrentTeamIndex];
        [BsonIgnore] public AvatarEntity CurrentAvatarEntity => ActiveTeam[CurrentCharacterIndex];
        [BsonIgnore] public bool IsSpawned => Owner.Scene != null && Owner.Scene.Entities.ContainsKey(CurrentAvatarEntity.EntityId);

        [BsonIgnore] public int MaxTeamSize
        {
            get
            {
                if (Owner.IsInMultiplayer)
                {
                    int max = GameServer.Configuration.Server.GameOptions.AvatarLimits.MultiplayerTeam;
                    if (Owner.World.Host == Owner)
                    {
                        return Math.Max(1, (int)Math.Ceiling(max / (double)Owner.World.Players.Count));
                    }
                    return Math.Max(1, (int)Math.Floor(max / (double)Owner.World.Players.Count));
                }
                else
                    return GameServer.Configuration.Server.GameOptions.AvatarLimits.SinglePlayerTeam;
            }
        }
        public TeamManager(Player player)
        {
            Owner = player;
            OwnerId = player.GameUid;
            AbilityManager = new TeamAbilityManager(this);
            for (int i = 1; i <= GameServer.Configuration.Server.GameOptions.Constants.DEFAULT_TEAMS; i++)
            {
                Teams.Add(i, new TeamInfo());
            }
        }

        public async Task OnLoadAsync(Player owner)
        {
            Owner = owner;
            AbilityManager = new TeamAbilityManager(this);
            ActiveTeam = new();
            // Point to the "real" avatars
            var reloadedTeams = new SortedList<int, TeamInfo>();
            foreach (var team in Teams)
            {
                reloadedTeams.Add(team.Key, new(team.Value.TeamName));
                foreach (var entry in team.Value.AvatarInfo)
                {
                    if (entry.Value == null) continue;
                    reloadedTeams[team.Key].AvatarInfo[entry.Key] = owner.Avatars.GetAvatarById(entry.Value.AvatarId);
                }
            }
            Teams = reloadedTeams;

            // You stay simple clones >:)
            TowerTeams.Values.AsParallel().ForAll(async w => await w.OnLoadAsync(owner));
            foreach (var characterIndex in Teams[CurrentTeamIndex].AvatarInfo)
            {
                if (characterIndex.Value == null) continue;
                ActiveTeam.Add(characterIndex.Key, new AvatarEntity(Teams[CurrentTeamIndex], (ushort)characterIndex.Key));
            }
        }

        /**
         * Search through all teams and if the team matches, return that index.
         * Otherwise, return -1.
         * No match could mean that the team does not currently belong to the player.
         */
        public int GetTeamId(TeamInfo team)
        {
            for (int i = 1; i <= Teams.Count; i++)
            {
                if (Teams[i] == team)
                {
                    return i;
                }
            }
            return -1;
        }

        public async Task<bool> AddToTeamAsync(Avatar.Avatar avatar, int teamIndex = -1, int cIndex = -1)
        {
            if (teamIndex == -1)
            {
                teamIndex = CurrentTeamIndex;
            }
            if (cIndex == -1)
            {
                for (int i = 0; i < GameServer.Configuration.Server.GameOptions.AvatarLimits.SinglePlayerTeam; i++)
                {
                    if (Teams[teamIndex].AvatarInfo[i] == null)
                    {
                        cIndex = i;
                        break;
                    }
                }
                if (cIndex == -1)
                {
                    Logger.DebugWriteLine($"failed to add avatar to team {teamIndex}");
                    return false;
                }
            }
            Teams[teamIndex].AddAvatar(avatar, cIndex);

            // Update Database
            await DatabaseManager.SaveTeamsAsync(this);

            return true;
        }

        private bool SetCurrentTeamId(int currentTeamIndex)
        {
            if (Teams.ContainsKey(currentTeamIndex))
            {
                CurrentTeamIndex = currentTeamIndex;
                return true;
            }
            else if (TowerTeams.ContainsKey(currentTeamIndex))
            {
                CurrentTeamIndex = currentTeamIndex;
                return true;
            }
            else return false;
        }

        public async Task UpdateTeamEntitiesAsync()
        {
            AvatarEntity currentEntity = CurrentAvatarEntity;
            int prevSelectedAvatarIndex = -1;

            // Create a copy of the active team
            Dictionary<uint, AvatarEntity> previousTeam = new(); // <avatarId, entity>
            foreach (var entity in ActiveTeam)
            {
                previousTeam.Add(entity.Value.Avatar.AvatarId, entity.Value);
            }

            // Clear active team entity list
            ActiveTeam.Clear();

            // update ActiveTeam using the entries of the current TeamInfo
            for (int i = 0; i < CurrentTeamInfo.AvatarInfo.Count; i++)
            {
                if (CurrentTeamInfo.AvatarInfo[i] == null) continue;
                uint avatarId = CurrentTeamInfo.AvatarInfo[i].AvatarId;

                if (previousTeam.TryGetValue(avatarId, out AvatarEntity? entity))
                {
                    previousTeam.Remove(avatarId);
                    if (entity == currentEntity)
                    {
                        prevSelectedAvatarIndex = i;
                    }
                }
                else
                {
                    entity = new AvatarEntity(CurrentTeamInfo, Owner.Scene, Owner.Avatars.GetAvatarById(avatarId));
                }

                ActiveTeam.Add(i, entity);
            }

            // Remove the remaining entities that didn't get added back to the active team
            foreach (AvatarEntity entity in previousTeam.Values)
            {
                //TODO apply correct visionType
                await Owner.Scene.RemoveEntityAsync(entity);
            }

            // Set new selected character index
            if (prevSelectedAvatarIndex == -1)
            {
                // Previous selected avatar is not in the same spot, we will select the current one in the prev slot
                prevSelectedAvatarIndex = Math.Min(CurrentCharacterIndex, ActiveTeam.Count - 1);
            }
            CurrentCharacterIndex = prevSelectedAvatarIndex;

            // Packets
            await Owner.World.BroadcastPacketAsync(new PacketSceneTeamUpdateNotify(Owner));

            // Skill charges packet - Yes, this is official server behavior as of 2.6.0
            ActiveTeam.AsParallel().ForAll(async w => await w.Value.Avatar.CurSkillDepot.SendAvatarSkillInfoNotify());

            // Check if character changed
            if (currentEntity != CurrentAvatarEntity)
            {
                // Remove and Add
                await Owner.Scene.ReplaceAvatarAsync(currentEntity, CurrentAvatarEntity);
            }
        }

        public async Task SetupAvatarTeamAsync(int teamId, IList<ulong> list)
        {
            // Sanity checks
            if (list.Count == 0 || list.Count > MaxTeamSize || Owner.IsInMultiplayer)
            {
                return;
            }

            // Get team
            if (!Teams.TryGetValue(teamId, out TeamInfo teamInfo)) return;

            // Set team data
            HashSet<Avatar.Avatar> newTeamAvatars = new();
            foreach (ulong guid in list)
            {
                Avatar.Avatar? avatar = Owner.Avatars.GetAvatarByGuid(guid);
                if (avatar == null || newTeamAvatars.Contains(avatar))
                {
                    // Should never happen
                    return;
                }
                newTeamAvatars.Add(avatar);
            }

            // Replace the old team with the new one
            teamInfo = new TeamInfo(newTeamAvatars, teamInfo.TeamName, teamInfo.IsTowerTeam);

            if (Teams.ContainsKey(teamId))
            {
                Teams[teamId] = teamInfo;
            }
            else
            {
                Teams.Add(teamId, teamInfo);
            }


            await Owner.SendPacketAsync(new PacketAvatarTeamUpdateNotify(Owner));

            if (teamId == GetTeamId(CurrentTeamInfo))
            {
                await UpdateTeamEntitiesAsync();
            }
            else
            {
                await Owner.SendPacketAsync(new PacketAvatarTeamUpdateNotify(Owner));
            }



        }


        public async Task SetupMpTeamAsync(List<ulong> list)
        {
            // Sanity checks
            if (list.Count == 0 || list.Count > MaxTeamSize || Owner.IsInMultiplayer)
            {
                return;
            }

            // Set team data
            HashSet<Avatar.Avatar> newTeam = new();
            foreach (ulong aLong in list)
            {
                Avatar.Avatar? avatar = Owner.Avatars.GetAvatarByGuid(aLong);
                if (avatar == null || newTeam.Contains(avatar))
                {
                    // Should never happen
                    return;
                }
                newTeam.Add(avatar);
            }

            // Replace the old MpTeam with the new one
            MpTeam = new TeamInfo(newTeam, MpTeam.TeamName, false);
        }

        public bool SetTeamName(int teamId, string teamName)
        {
            if (Teams.TryGetValue(teamId, out TeamInfo teamInfo))
            {
                return false;
            }
            else
            {
                teamInfo.TeamName = teamName;
                return true;
            }
        }

        public async Task ChangeAvatar(ulong guid)
        {
            AvatarEntity oldEntity = CurrentAvatarEntity;

            if (guid == oldEntity.Avatar.Guid)
            {
                return;
            }

            AvatarEntity newEntity = null;
            int index = -1;
            for (int i = 0; i < ActiveTeam.Count; i++)
            {
                if (guid == ActiveTeam[i].Avatar.Guid)
                {
                    index = i;
                    newEntity = ActiveTeam[i];
                }
            }

            if (index < 0 || newEntity == oldEntity)
            {
                return;
            }

            // Set index
            CurrentCharacterIndex = index;

            // Old entity motion state
            oldEntity.SetMotionState(MotionState.Standby);

            // Remove and Add
            await Owner.Scene.ReplaceAvatarAsync(oldEntity, newEntity);
        }

        public async Task OnAvatarDie(long dieGuid)
        {
            AvatarEntity deadAvatar = CurrentAvatarEntity;

            if (deadAvatar.LiveState == LifeState.LIFE_ALIVE || deadAvatar.EntityId != dieGuid)
            {
                return;
            }

            uint killedBy = deadAvatar.KilledBy;
            PlayerDieType killedType = deadAvatar.KilledType;

            if (killedType == PlayerDieType.Drawn)
            {
                //TODO
            }
            else
            {
                // Replacement avatar
                AvatarEntity replacement = null;
                int replaceIndex = -1;

                for (int i = 0; i < ActiveTeam.Count; i++)
                {
                    AvatarEntity entity = ActiveTeam[i];
                    if (entity.LiveState == LifeState.LIFE_ALIVE)
                    {
                        replaceIndex = i;
                        replacement = entity;
                        break;
                    }
                }

                if (replacement == null)
                {
                    // No more living team members...
                    await Owner.SendPacketAsync(new PacketWorldPlayerDieNotify(deadAvatar.EntityId, killedType, killedBy));
                }
                else
                {
                    // Set index and spawn replacement member
                    CurrentCharacterIndex = replaceIndex;
                    await Owner.Scene.AddEntityAsync(replacement);
                }
            }
        }

        internal async Task SetCurrentTeam(uint teamId)
        {
            if (Owner.IsInMultiplayer)
            {
                return;
            }

            // Get team
            TeamInfo teamInfo = Teams.GetValueOrDefault((int)teamId);
            if (teamInfo == null || teamInfo.AvatarInfo.Count == 0)
            {
                return;
            }

            // Set
            SetCurrentTeamId((int)teamId);
        }
    }
}
