using System.Numerics;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.Ability;
using Weedwacker.GameServer.Systems.Script.Scene;
using Weedwacker.Shared.Network.Proto;
using EnterReason = Weedwacker.GameServer.Enums.EnterReason;

namespace Weedwacker.GameServer.Systems.World
{
    internal class World : BaseEntity // Yes... the world is an entity...
    {
        public readonly Player.Player Host;
        public HashSet<Player.Player> Players { get; private set; } = new();
        private readonly Dictionary<int, Scene> Scenes = new();
        public uint LevelEntityId { get; private set; }
        private int NextEntityId = 0;
        private uint NextPeerId = 0;
        public int WorldLevel { get; private set; }
        public bool IsMultiplayer { get; private set; } = false;
        public uint HostPeerId => Host.PeerId;
        public World(Player.Player owner)
        {
            Host = owner;
            LevelEntityId = GetNextEntityId(EntityIdType.MPLEVEL);
            AbilityManager = new WorldAbilityManager(this);
            WorldLevel = owner.Profile.WorldLevel;
            GameServer.RegisterWorld(this);
        }
        public uint GetNextPeerId() => ++NextPeerId;

        public async Task<Scene?> GetSceneById(int sceneId)
        {
            // Get scene normally
            Scene? scene = Scenes.GetValueOrDefault(sceneId);
            if (scene != null)
            {
                return scene;
            }

            // Create scene from scene data if it doesn't exist
            SceneData? sceneData = GameData.SceneDataMap.GetValueOrDefault(sceneId);
            if (sceneData != null)
            {
                scene = await Scene.CreateAsync(this, sceneData);
                Scenes.Add(scene.SceneData.id, scene);
                return scene;
            }

            return null;
        }

        public uint GetNextEntityId(EntityIdType idType) => (uint)(((int)idType << 24) + ++NextEntityId);

        public async Task<bool> AddPlayerAsync(Player.Player player, EnterReason reason, EnterType type = EnterType.Self, bool useDefaultBornPosition = false)
        {
            // Check if player already in
            if (Players.Contains(player))
            {
                return false;
            }

            // Remove player from prev world
            if (player.World != null)
            {
                await player.World.RemovePlayerAsync(player);
            }

            // Register
            player.World = this;
            Players.Add(player);

            // Set player variables
            player.PeerId = GetNextPeerId();
            player.TeamManager.EntityId = GetNextEntityId(EntityIdType.TEAM);

            // Copy main team to multiplayer team
            if (IsMultiplayer)
            {
                player.TeamManager.MpTeam.CopyFrom(player.TeamManager.CurrentSinglePlayerTeamInfo, player.TeamManager.MaxTeamSize);
                player.TeamManager.CurrentCharacterIndex = 0;
            }

            // Add to scene
            Scene scene = await GetSceneById(player.SceneId);
            await TransferPlayerToSceneAsync(player, reason, type, scene.SceneId, player.Position, useDefaultBornPosition: useDefaultBornPosition);

            // Info packet for other players
            if (Players.Count > 1)
            {
                await UpdatePlayerInfosAsync(player);
            }

            return true;
        }

        public async Task RemovePlayerAsync(Player.Player player)
        {
            if (!Players.Contains(player)) return;
            // Remove team entities
            await player.SendPacketAsync(new PacketDelTeamEntityNotify(player.SceneId, player.TeamManager.EntityId));

            // Remove from scene
            Scene scene = await GetSceneById(player.SceneId);
            await scene.RemovePlayerAsync(player);

            // Deregister
            Players.Remove(player);
            player.World = null;
            player.TeamManager.EntityId = 0;

            // Info packet for other players
            if (Players.Count > 0)
            {
                await UpdatePlayerInfosAsync(player);
            }

            // Disband world if host leaves
            if (Host == player)
            {
                foreach (Player.Player victim in Players)
                {
                    // Instantiate their own world
                    World world = new(victim);
                    await world.AddPlayerAsync(victim, EnterReason.TeamKick, EnterType.Self);
                }
            }
        }

        public void DeregisterScene(Scene scene)
        {
            Scenes.Remove(scene.SceneData.id);
        }

        public async Task<bool> TransferPlayerToSceneAsync(Player.Player player, EnterReason enterReason, EnterType enterType, int sceneId, Vector3 teleportTo, Vector3 teleportToRot = default, bool useDefaultBornPosition = true)
        {
            if (!GameData.SceneDataMap.TryGetValue(sceneId, out SceneData sceneData))
            {
                return false;
            }

            Scene? oldScene = player.Scene;
            int oldSceneId = oldScene == null ? 0 : oldScene.SceneId;
            Scene newScene = await GetSceneById(sceneId);

            if (oldScene != null)
            {
                newScene.PrevScene = oldScene.SceneId;
                // Don't deregister scenes if the player is going to tp back into them
                await oldScene.RemovePlayerAsync(player, oldScene.SceneId == sceneId);
            }

            if (useDefaultBornPosition)
            {
                SceneInfo sceneInfo = await GameData.GetSceneScriptsAsync(sceneId);
                teleportTo = sceneInfo.scene_config.born_pos;
                player.Rotation = sceneInfo.scene_config.born_rot;
            }

            await newScene.AddPlayerAsync(player, enterReason, teleportTo, enterType, oldSceneId, player.Position, teleportToRot);

            return true;
        }

        private async Task UpdatePlayerInfosAsync(Player.Player paramPlayer)
        {
            Players.AsParallel().ForAll(async player =>
            {
                // Dont send packets if player is logging in and filter out joining player
                if (!player.HasSentLoginPackets || player == paramPlayer) return;


                // Update team of all players since max players has been changed - Probably not the best way to do it
                if (IsMultiplayer)
                {
                    player.TeamManager.MpTeam.CopyFrom(player.TeamManager.MpTeam, player.TeamManager.MaxTeamSize);
                    await player.TeamManager.UpdateTeamEntitiesAsync();
                }

                // Dont send packets if player is loading into the scene
                if (player.SceneLoadState < SceneLoadState.INIT)
                {
                    await Task.WhenAll(new Task[]
                    {
                        // World player info packets
                        player.SendPacketAsync(new PacketWorldPlayerInfoNotify(this)),
                        player.SendPacketAsync(new PacketWorldPlayerRTTNotify(this)),
                        player.SendPacketAsync(new PacketScenePlayerInfoNotify(this)), // Maybe the Scene should send this?

                        // Team packets
                        player.SendPacketAsync(new PacketSyncTeamEntityNotify(player)),
                        player.SendPacketAsync(new PacketSyncScenePlayTeamEntityNotify(player)),
                    });
                }
            });


        }

        public async Task BroadcastPacketAsync(BasePacket packet)
        {
            // Send to all players - might have to check if player has been sent data packets
            Players.AsParallel().ForAll(async p => await p.SendPacketAsync(packet));
        }

        public async Task BroadcastPacketToOthersAsync(BasePacket packet, Player.Player player)
        {
            // Send to all players - might have to check if player has been sent data packets
            Players.AsParallel().ForAll(async p => { if (p != player) await p.SendPacketAsync(packet); });
        }

        // Returns false if there are no players in this world
        public async Task<bool> OnTickAsync()
        {
            if (!Players.Any()) return false;
            Scenes.AsParallel().ForAll(async x => await x.Value.OnTickAsync());
            return true;
        }
    }
}
