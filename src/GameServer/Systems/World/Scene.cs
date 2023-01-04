using System.Collections.Concurrent;
using System.Numerics;
using MongoDB.Driver;
using Octree;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.BinOut.Scene.Point;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.GameServer.Systems.Script.Scene;
using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.SceneGroup;
using EnterReason = Weedwacker.GameServer.Enums.EnterReason;

namespace Weedwacker.GameServer.Systems.World
{
    internal class Scene
    {
        public readonly World World;
        public readonly SceneData SceneData;
        public int SceneId => SceneData.id;
        public readonly List<Player.Player> Players = new();
        private HashSet<SceneGroup> LoadedGroups = new();
        public readonly ConcurrentDictionary<uint, BaseEntity> Entities = new(); // entityId
        public readonly ConcurrentDictionary<uint, ScriptEntity> ScriptEntities = new(); // entityId
        public readonly HashSet<SpawnInfo> SpawnedEntities;
        public readonly HashSet<SpawnInfo> DeadSpawnedEntities;
        public int AutoCloseTime;
        public uint Time { get; private set; }
        public SceneScriptManager ScriptManager { get; private set; }
        public readonly ScenePointData PointData;
        public readonly DungeonData? DungeonData;
        public int PrevScene; // Id of the previous scene
        public int PrevScenePoint;
        public Dictionary<Tuple<int, int>, int> ActiveAreaWeathers; // <areaID1, areaID2> weatherId>
        public HashSet<uint> SceneTags; // TODO apply based on host's data
        private ConcurrentBag<SceneEntity> BornNotifyQueue = new();
        private static Dictionary<int, Dictionary<SceneBlock, PointOctree<SceneGroup>>> GroupTrees;

        public static Task<Scene> CreateAsync(World world, SceneData sceneData)
        {
            Scene scene = new Scene(world, sceneData);
            return scene.Init();
        }
        private Scene(World world, SceneData sceneData)
        {
            World = world;
            SceneData = sceneData;
            PointData = GameData.ScenePointDataMap["scene" + sceneData.id + "_point"];
            if (sceneData.type == SceneType.SCENE_DUNGEON)
                DungeonData = GameData.DungeonDataMap.Where(w => w.Value.sceneId == sceneData.id).First().Value;

            Time = 8 * 60;
            PrevScene = 3;

            //TODO
            SceneTags = new HashSet<uint>(GameData.SceneTagDataMap.Where(w => w.Value.sceneId == SceneId).Select(s => (uint)s.Key));

            //ScriptManager = GameData.SceneScripts[GetId()];
        }

        private async Task<Scene> Init()
        {
            if (GroupTrees != null)
            {
                if (GroupTrees[SceneId] != null)
                {
                    return this;
                }
            }
            else
            {
                GroupTrees = new();
            }
            GroupTrees[SceneId] = new();
            SceneInfo info = await GameData.GetSceneScriptsAsync(SceneId);
            foreach (var block in info.BlocksInfo.Values)
            {
                PointOctree<SceneGroup> tree = new PointOctree<SceneGroup>(5000, new Vector3(0,0,0), 1);
                foreach (var group in block.groups.Values)
                {
                    tree.Add(block.GroupsInfo[group.id], group.pos);
                }
                GroupTrees[SceneId][block] = tree;
            }
            return this;
        }

        private async Task CheckSceneBlockRegions()
        {
            SceneInfo info = await GameData.GetSceneScriptsAsync(SceneId);
            foreach (var player in Players)
            {
                foreach(var block_rect in info.block_rects)
                {
                    if(player.Position.X > block_rect.Value.min.X && player.Position.X < block_rect.Value.max.X && player.Position.Z > block_rect.Value.min.Z && player.Position.Z < block_rect.Value.max.Z)
                    {
                        var block = info.BlocksInfo[info.blocks[block_rect.Key]];

                        // Load nearby groups
                        var nearbyGroups = GroupTrees[SceneId][block].GetNearby(player.Position, GameServer.Configuration.Server.LoadEntitiesForPlayerRange);
                        var groupsToLoad = nearbyGroups.Intersect(block.StaticGroups).Except(LoadedGroups);
                        if (groupsToLoad.Any())
                        {
                            groupsToLoad.AsParallel().ForAll(w => w.OnInitAsync(this));
                            LoadedGroups = LoadedGroups.Union(groupsToLoad).ToHashSet();
                        }

                        var toUnload = LoadedGroups.Except(nearbyGroups);
                        if (toUnload.Any())
                        {
                            toUnload.AsParallel().ForAll(w => w.OnUnload(this));
                            LoadedGroups = LoadedGroups.Except(toUnload).ToHashSet();
                        }
                    }
                }
            }
        }
        public BaseEntity? GetEntityById(uint id)
        {
            if (Entities.TryGetValue(id, out BaseEntity entity))
            {
                return entity;
            }
            else if (ScriptEntities.TryGetValue(id, out ScriptEntity scriptEntity))
            {
                return scriptEntity;
            }
            else
                return null;
        }

        public void ChangeTime(int time)
        {
            Time = (uint)time % 1440;
        }

        public bool IsInScene(SceneEntity entity) => Entities.ContainsKey(entity.EntityId);

        public async Task UpdateActiveAreaWeathersAsync(Tuple<int, int> areaIDs)
        {
            //TODO update based on host's weather and quest progression
            await BroadcastPacketAsync(new PacketSceneAreaWeatherNotify(ClimateType.CLIMATE_SUNNY, 1));
        }

        public async Task AddPlayerAsync(Player.Player player, EnterReason reason, Vector3 newPosition, EnterType type = EnterType.Self, int oldSceneId = default, Vector3 oldPos = default, Vector3 newRot = default)
        {
            // Check if player already in
            if (Players.Contains(player))
            {
                return;
            }

            // Add
            Players.Add(player);
            Entities.TryAdd(player.TeamManager.EntityId, player.TeamManager);
            await player.SetSceneAsync(this);
            player.Position = newPosition;
            player.Rotation = newRot;

            // Update Database
            var filter = Builders<Player.Player>.Filter.Where(w => w.AccountUid == player.AccountUid);
            var update = Builders<Player.Player>.Update.Set(w => w.PositionArray, player.PositionArray).Set(w => w.RotationArray, player.RotationArray);
            await DatabaseManager.UpdatePlayerAsync(filter, update);

            await player.SendPacketAsync(new PacketPlayerEnterSceneNotify(player, type, reason, this, newPosition, oldSceneId, oldPos));

            await SetupPlayerAvatarsAsync(player);
        }

        public async Task RemovePlayerAsync(Player.Player player, bool dontDestroyWhenEmpty = false)
        {
            // Remove player from scene
            Players.Remove(player);
            Entities.Remove(player.TeamManager.EntityId, out BaseEntity? idc);

            // Remove player avatars
            SortedList<int, AvatarEntity> team = player.TeamManager.ActiveTeam;
            await RemoveEntitiesAsync(team.Values, Shared.Network.Proto.VisionType.Remove);
            team.Clear();

            // Remove player gadgets
            foreach (ClientGadgetEntity gadget in player.GadgetManager.Gadgets)
            {
                await RemoveEntityAsync(gadget);
            }

            // Deregister scene if not in use
            if (Players.Count <= 0 && !dontDestroyWhenEmpty)
            {
                World.DeregisterScene(this);
            }
        }

        private async Task SetupPlayerAvatarsAsync(Player.Player player)
        {
            await Task.Yield();
            // Add new entities for player
            TeamInfo teamInfo = player.TeamManager.CurrentTeamInfo;
            player.TeamManager.ActiveTeam = new();
            foreach (var entry in teamInfo.AvatarInfo)
            {
                if (entry.Value == null) continue;
                AvatarEntity entity = new AvatarEntity(teamInfo, player.Scene, player.Avatars.GetAvatarById(entry.Value.AvatarId));
                player.TeamManager.ActiveTeam.Add(entry.Key, entity);
            }
        }

        public async Task SpawnPlayerAsync(Player.Player player)
        {
            var teamManager = player.TeamManager;
            if (IsInScene(teamManager.CurrentAvatarEntity))
            {
                return;
            }

            if (teamManager.CurrentAvatarEntity.FightProps[FightProperty.FIGHT_PROP_CUR_HP] <= 0f)
            {
                teamManager.                CurrentAvatarEntity.FightProps[FightProperty.FIGHT_PROP_CUR_HP] = 1f;
            }

            await AddEntityAsync(teamManager.CurrentAvatarEntity);

            // Notify the client of any extra skill charges
            teamManager.ActiveTeam.AsParallel().ForAll(async x => await x.Value.Avatar.CurSkillDepot.SendAvatarSkillInfoNotify());
        }

        public async Task RespawnPlayerAsync(Player.Player player)
        {
            //player.StaminaManager.stopSustainedStaminaHandler(); // prevent drowning immediately after respawn

            // Revive all team members
            foreach (AvatarEntity entity in player.TeamManager.ActiveTeam.Values)
            {
                entity.FightProps[
                        FightProperty.FIGHT_PROP_CUR_HP] =
                    entity.FightProps[FightProperty.FIGHT_PROP_MAX_HP] * 0.4f;

                await player.SendPacketAsync(new PacketAvatarFightPropUpdateNotify(entity.Avatar, FightProperty.FIGHT_PROP_CUR_HP));
                await player.SendPacketAsync(new PacketAvatarLifeStateChangeNotify(entity.Avatar));
            }
            Vector3 respawnPos = GetRespawnPosition(player);

            // Teleport player and set player position
            await player.SendPacketAsync(new PacketPlayerEnterSceneNotify(player, EnterType.Self, EnterReason.Revival, player.Scene, respawnPos));
            player.Position = respawnPos;
        }
        public Vector3 GetRespawnPosition(Player.Player player)
        {
            Vector3 deathPos = player.Position;

            //TODO

            return deathPos;
        }

        private async Task AddEntityDirectly(SceneEntity entity)
        {
            if (entity is ScriptEntity scriptEntity && scriptEntity.GroupId != 0 && !ScriptEntities.ContainsKey(entity.EntityId)) // need an extra check against client gadgets. Oh if only I could do multiple inheritance
            {
                ScriptEntities.TryAdd(scriptEntity.EntityId, scriptEntity);
                await entity.OnCreateAsync(); // Call entity create event
            }
            else if(!Entities.ContainsKey(entity.EntityId))
            {
                Entities.TryAdd(entity.EntityId, entity);
                await entity.OnCreateAsync(); // Call entity create event
            }
        }

        public async Task AddEntityAsync(SceneEntity? entity)
        {
            if (entity == null) return;
            await AddEntityDirectly(entity);
            await BroadcastPacketAsync(new PacketSceneEntityAppearNotify(entity));

        }

        public async Task AddEntityToSingleClient(Player.Player player, SceneEntity entity)
        {
            await AddEntityDirectly(entity);
            await player.SendPacketAsync(new PacketSceneEntityAppearNotify(entity));

        }

        public async Task AddEntitiesAsync(IEnumerable<SceneEntity> entities, Shared.Network.Proto.VisionType visionType = Shared.Network.Proto.VisionType.Born)
        {
            if (entities == null || !entities.Any())
            {
                return;
            }
            foreach (SceneEntity entity in entities)
            {
                await AddEntityDirectly(entity);
            }

            await BroadcastPacketAsync(new PacketSceneEntityAppearNotify(entities, visionType));
        }

        public async Task<bool> RemoveEntityAsync(SceneEntity entity, Shared.Network.Proto.VisionType visionType = Shared.Network.Proto.VisionType.Die)
        {
            if (ScriptEntities.Remove(entity.EntityId, out ScriptEntity idc) || Entities.Remove(entity.EntityId, out BaseEntity idc2))
            {
                await BroadcastPacketAsync(new PacketSceneEntityDisappearNotify(entity, visionType));
                return true;
            }
            else return false;
        }
        public async Task RemoveEntitiesAsync(IEnumerable<SceneEntity> entity, Shared.Network.Proto.VisionType visionType)
        {
            var toRemove = entity.Where(w => ScriptEntities.Remove(w.EntityId, out ScriptEntity idc) || Entities.Remove(w.EntityId, out BaseEntity idc2));
            if (toRemove.Any())
            {
                await BroadcastPacketAsync(new PacketSceneEntityDisappearNotify(toRemove, visionType));
            }
        }
        public async Task ReplaceAvatarAsync(AvatarEntity oldEntity, AvatarEntity newEntity)
        {
            Entities.Remove(oldEntity.EntityId, out BaseEntity idc);
            await AddEntityDirectly(newEntity);
            await BroadcastPacketAsync(new PacketSceneEntityDisappearNotify(oldEntity, Shared.Network.Proto.VisionType.Replace));
            await BroadcastPacketAsync(new PacketSceneEntityAppearNotify(newEntity, Shared.Network.Proto.VisionType.Replace, oldEntity.EntityId));
        }

        public async Task ShowOtherEntitiesAsync(Player.Player player)
        {
            List<SceneEntity> entities = new();
            SceneEntity currentEntity = player.TeamManager.CurrentAvatarEntity;

            foreach (SceneEntity entity in Entities.Values.Concat(ScriptEntities.Values).Where(w => w is SceneEntity))
            {
                if (entity == currentEntity)
                {
                    continue;
                }
                entities.Add(entity);
            }

            await player.SendPacketAsync(new PacketSceneEntityAppearNotify(entities, Shared.Network.Proto.VisionType.Meet));
        }

        public async Task HandleAttackAsync(AttackResult result)
        {
            //TODO use AttackResult's data properly

            SceneEntity target = (SceneEntity)GetEntityById(result.DefenseId);

            if (target == null)
            {
                return;
            }

            await target.DamageAsync(result.Damage, result.AttackerId);
        }

        public async Task KillEntityAsync(SceneEntity target, uint attackerId = 0)
        {
            SceneEntity? attacker = null;

            if (attackerId != 0)
            {
                attacker = (SceneEntity)GetEntityById(attackerId);
            }

            if (attacker != null)
            {
                // Check codex
                if (attacker is ClientGadgetEntity gadgetAttacker)
                {
                    var clientGadgetOwner = Entities[gadgetAttacker.OwnerEntityId];
                    if (clientGadgetOwner is AvatarEntity)
                    {
                        //((ClientGadgetEntity)attacker).Owner.Codex.CheckAnimal(target, CodexAnimalData.CodexAnimalUnlockCondition.CODEX_COUNT_TYPE_KILL);
                    }
                }
                else if (attacker is AvatarEntity avatarAttacker)
                {
                    //avatarAttacker.Avatar.Owner.Codex.CheckAnimal(target, CodexAnimalData.CodexAnimalUnlockCondition.CODEX_COUNT_TYPE_KILL);
                }
            }

            // Packet
            await BroadcastPacketAsync(new PacketLifeStateChangeNotify(target, LifeState.LIFE_DEAD, attackerId));

            // Remove entity from world
            await RemoveEntityAsync(target);

            // Death event
            await target.OnDeathAsync(attackerId);
        }

        public async Task OnTickAsync()
        {
            await CheckSceneBlockRegions();
            if(BornNotifyQueue.Any())
            {
                await BroadcastPacketAsync(new PacketSceneEntityAppearNotify(BornNotifyQueue));
            }
            BornNotifyQueue.Clear();
        }

        public static int GetEntityLevel(int baseLevel, int worldLevelOverride)
        {
            int level = worldLevelOverride > 0 ? worldLevelOverride + baseLevel - 22 : baseLevel;
            level = level >= 100 ? 100 : level;
            level = level <= 0 ? 1 : level;

            return level;
        }

        // Gadgets

        public async Task OnPlayerCreateGadget(ClientGadgetEntity gadget)
        {
            // Directly add
            await AddEntityDirectly(gadget);

            // Add to owner's gadget list
            gadget.Owner.GadgetManager.Gadgets.Add(gadget);

            await BroadcastPacketToOthersAsync(gadget.Owner, new PacketSceneEntityAppearNotify(gadget));
        }

        public async Task OnPlayerDestroyGadget(uint entityId)
        {
            SceneEntity entity = (SceneEntity)Entities[entityId];

            if (entity == null || !(entity is ClientGadgetEntity))
            {
                return;
            }

            // Get and remove entity
            ClientGadgetEntity gadget = (ClientGadgetEntity)entity;
            Entities.Remove(gadget.EntityId, out BaseEntity idc);

            // Remove from owner's gadget list
            gadget.Owner.GadgetManager.Gadgets.Remove(gadget);

            await BroadcastPacketToOthersAsync(gadget.Owner, new PacketSceneEntityDisappearNotify(gadget, Shared.Network.Proto.VisionType.Die));
        }

        // Broadcasting
        public async Task BroadcastPacketAsync(BasePacket packet)
        {
            // Send to all players - might have to check if player has been sent data packets
            var tasks = new List<Task>();
            foreach (Player.Player player in Players)
            {
                tasks.Add(player.SendPacketAsync(packet));
            }
            await Task.WhenAll(tasks);
        }

        public async Task BroadcastPacketToOthersAsync(Player.Player excludedPlayer, BasePacket packet)
        {
            // Send to all players - might have to check if player has been sent data packets
            foreach (Player.Player player in Players)
            {
                if (player == excludedPlayer)
                {
                    continue;
                }
                // Send
                await player.SendPacketAsync(packet);
            }
        }

        public async Task AddItemEntity(int itemId, int amount, SceneEntity bornForm)
        {
            if (!GameData.ItemDataMap.TryGetValue(itemId, out ItemData itemData))
            {
                return;
            }
            if (itemData.itemType == ItemType.ITEM_RELIQUARY || itemData.itemType == ItemType.ITEM_WEAPON)
            {
                float range = (1.5f + (.05f * amount));
                for (int i = 0; i < amount; i++)
                {
                    Vector3 pos = bornForm.Position;
                    ItemEntity entity = new ItemEntity(this, null, itemData, pos, 1);
                    await AddEntityAsync(entity);
                }
            }
            else
            {
                ItemEntity entity = new ItemEntity(this, null, itemData, bornForm.Position, amount);
                await AddEntityAsync(entity);
            }
        }
    }
}
