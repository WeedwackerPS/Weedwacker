using System.Numerics;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.Shop;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;
using EnterReason = Weedwacker.GameServer.Enums.EnterReason;

namespace Weedwacker.GameServer.Systems.Player
{
    // MongoDb collection: "players"
    internal class Player
    {
        [BsonId]
        [BsonElement("_id")]
        public string AccountUid { get; private set; }
        [BsonElement] public uint GameUid { get; private set; }
        [BsonElement] public PlayerProfile Profile;
        [BsonElement] public uint MainCharacterId { get; private set; } = 0;
        [BsonIgnore] public World.World? World;
        [BsonIgnore] public Scene? Scene { get; private set; }
        [BsonElement] public uint SceneId { get; private set; }
        [BsonElement] public Tuple<uint, uint> WorldAreaIds { get; private set; } // <areaID1, areaID2>
        [BsonElement] public uint RegionId { get; private set; } = 1;
        [BsonElement] public uint WidgetId;
        [BsonIgnore] public uint PeerId;
        [BsonIgnore] public Vector3 Position;
        [BsonIgnore] public Vector3 Rotation;
        // Quick Hack for mongodb
        [BsonElement("Position")] public float[] PositionArray { get => new[] { Position.X, Position.Y, Position.Z }; set => Position = new(value[0], value[1], value[2]); }
        [BsonElement("Rotation")] public float[] RotationArray { get => new[] { Rotation.X, Rotation.Y, Rotation.Z }; set => Rotation = new(value[0], value[1], value[2]); }
        public int NextResinRefresh;
        public int LastDailyReset;
        public Dictionary<PlayerProperty, int> PlayerProperties { get; set; } = new(); // SET ONLY THROUGH THE PROPMANAGER
        [BsonIgnore] public PlayerPropertyManager PropManager;
        [BsonIgnore] public MapMarksManager MapMarksManager;
        [BsonIgnore] public OpenStateManager OpenStateManager;
        [BsonIgnore] public ResinManager ResinManager;
        [BsonIgnore] public StaminaManager StaminaManager;
        [BsonIgnore] public Connection? Session; // Set by HandleGetPlayerTokenReq
        [BsonIgnore] public string Token { get; set; } // Obtained and used When Logging in
        [BsonIgnore] public uint EnterSceneToken;
        private long NextSendPlayerLocTime = 0;
        private long NextSendPlayerTimeNotify = 0;
        [BsonIgnore] public bool Paused { get; private set; }
        [BsonIgnore] public bool HasSentLoginPackets { get; private set; } = false;
        [BsonIgnore] private ulong NextGuid = 0;
        [BsonIgnore] public SceneLoadState SceneLoadState = SceneLoadState.NONE;
        [BsonIgnore] public Avatar.AvatarManager? Avatars; // Loaded by DatabaseManager
        [BsonIgnore] public BattlePassManager BattlePassManager; // Loaded by DatabaseManager
        [BsonIgnore] public EnergyManager EnergyManager; // Loaded by DatabaseManager
        [BsonIgnore] public ExpManager ExpManager; // Loaded by DatabaseManager
        [BsonIgnore] public ClientGadgetEntityManager GadgetManager; // Loaded by DatabaseManager
        [BsonIgnore] public Inventory.InventoryManager Inventory; // Loaded by DatabaseManager
        [BsonIgnore] public ProgressManager ProgressManager; // Loaded by DatabaseManager
        [BsonIgnore] public ShopManager ShopManager; // Loaded by DatabaseManager
        [BsonIgnore] public Social.SocialManager SocialManager; // Loaded by DatabaseManager
        [BsonIgnore] public TeamManager TeamManager; // Loaded by DatabaseManager

        [BsonIgnore] public InvokeNotifier<CombatInvokeEntry> CombatInvNotifyList;
        [BsonIgnore] public InvokeNotifier<AbilityInvokeEntry> AbilityInvNotifyList;
        [BsonIgnore] public InvokeNotifier<AbilityInvokeEntry> ClientAbilityInitFinishNotifyList;

        [BsonIgnore] public string? NickName => Profile.Nickname;
        [BsonIgnore] public bool IsInMultiplayer => World != null && World.IsMultiplayer;
        [BsonIgnore] public PlayerLocationInfo PlayerLocationInfo => new() { Uid = (uint)GameUid, Pos = new() { X = Position.X, Y = Position.Y, Z = Position.Z }, Rot = new() { X = Rotation.X, Y = Rotation.Y, Z = Rotation.Z } };

        public Player(string heroName, string accountUid, uint gameUid)
        {
            Profile = new(heroName);

            AccountUid = accountUid;
            BattlePassManager = new(this);
            EnergyManager = new(this);
            ExpManager = new(this);
            GadgetManager = new(this);
            GameUid = gameUid;
            ProgressManager = new(this);
            MapMarksManager = new(this);
            PropManager = new(this);
            ResinManager = new(this);
            ShopManager = new(this);
            SocialManager = new(this);
            OpenStateManager = new(this);
            StaminaManager = new(this);
            CombatInvNotifyList = new(this, typeof(PacketCombatInvocationsNotify));
            AbilityInvNotifyList = new(this, typeof(PacketAbilityInvocationsNotify));
            ClientAbilityInitFinishNotifyList = new(this, typeof(PacketClientAbilityInitFinishNotify));
        }

        private async Task OnCreate()
        {
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_PLAYER_LEVEL, 1, false);
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_PLAYER_WORLD_LEVEL, 0, false);
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_IS_SPRING_AUTO_USE, 1, false);
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_SPRING_AUTO_USE_PERCENT, 50, false);
            await ResinManager.AddResinAsync(160);
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_IS_FLYABLE, 0, false);
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_MAX_STAMINA, 10000, false);
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_CUR_PERSIST_STAMINA, 10000, false);
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_IS_TRANSFERABLE, 1, false);
            ProgressManager.OnPlayerCreate();

            // Pick character
            Session.State = SessionState.PICKING_CHARACTER;
            await Session.SendPacketAsync(new BasePacket(OpCode.DoSetPlayerBornDataNotify));
        }

        public ulong GetNextGameGuid()
        {
            ulong nextId = ++NextGuid;
            return ((ulong)GameUid << 32) + nextId;
        }

        public async Task<bool> SetMainCharacter(uint avatarId, string heroName)
        {
            if (GameData.AvatarHeroEntityDataMap.ContainsKey(avatarId) && MainCharacterId == 0)
            {
                MainCharacterId = avatarId;
                Profile.HeroName = heroName;
                Profile.Nickname = heroName;
                Profile.HeadImage = new() { AvatarId = (uint)avatarId, CostumeId = 0 };

                // Update Database
                var filter = Builders<Player>.Filter.Where(w => w.AccountUid == AccountUid);
                var update = Builders<Player>.Update.Set(w => w.Profile, Profile).Set(w => w.MainCharacterId, avatarId);
                await DatabaseManager.UpdatePlayerAsync(filter, update);
                return true;
            }
            else
                return false;

        }
        public async Task SetSceneAsync(Scene? scene)
        {
            Scene = scene;
            if (scene == null) SceneId = 0;
            else SceneId = scene.SceneData.id;

            // Update Database
            var filter = Builders<Player>.Filter.Where(w => w.AccountUid == AccountUid);
            var update = Builders<Player>.Update.Set(w => w.SceneId, SceneId);
            await DatabaseManager.UpdatePlayerAsync(filter, update);
        }

        public async Task EnterWorldAreaAsync(uint areaType, uint areaID, bool isInit = false)
        {
            if (areaType == 2)
            {
                if (!isInit) await Scene.UpdateActiveAreaWeathersAsync(WorldAreaIds);
                WorldAreaIds = Tuple.Create(WorldAreaIds.Item1, areaID);
            }
            else
                WorldAreaIds = Tuple.Create(areaID, WorldAreaIds.Item2);

            // Update Database
            var filter = Builders<Player>.Filter.Where(w => w.AccountUid == AccountUid);
            var update = Builders<Player>.Update.Set(w => w.WorldAreaIds, WorldAreaIds);
            await DatabaseManager.UpdatePlayerAsync(filter, update);
        }

        public async void OnTickAsync()
        {
            if (Session == null)
            {
                return;
            }
            // Check ping
            if (Session.LastPingTime > DateTimeOffset.Now.ToUnixTimeMilliseconds() + 60000)
            {
                Session.Stop();
                return;
            }
            // Ping
            if (World != null)
            {
                // RTT notify - very important to send this often
                await SendPacketAsync(new PacketWorldPlayerRTTNotify(World));

                // Update player locations if in multiplayer every 5 seconds
                long time = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                if (World.IsMultiplayer && Scene != null && time > NextSendPlayerLocTime)
                {
                    await SendPacketAsync(new PacketWorldPlayerLocationNotify(World));
                    await SendPacketAsync(new PacketScenePlayerLocationNotify(Scene));

                    NextSendPlayerLocTime = DateTimeOffset.Now.ToUnixTimeMilliseconds() + 5000;
                }
                if (Scene != null && time > NextSendPlayerTimeNotify)
                {
                    // Send every 10 seconds
                    await SendPacketAsync(new PacketPlayerTimeNotify(this));
                    NextSendPlayerTimeNotify = DateTimeOffset.Now.ToUnixTimeMilliseconds() + 10000;

                    // periodically update location in the database
                    var filter = Builders<Player>.Filter.Where(w => w.AccountUid == AccountUid);
                    var update = Builders<Player>.Update.Set(w => w.PositionArray, PositionArray).Set(w => w.RotationArray, RotationArray);
                    await DatabaseManager.UpdatePlayerAsync(filter, update);
                }
            }
            // Recharge resin.
            await ResinManager.RechargeResin();
            //await StaminaManager.OnTickAsync();
        }

        public async Task OnLoginAsync()
        {
            // Show opening cutscene if player has no avatars
            if (Avatars.Avatars.Count == 0)
            {
                await OnCreate();
                return;

            }

            await SendPacketAsync(new PacketPlayerDataNotify(this));
            await OpenStateManager.OnLoginAsync();
            await SendPacketAsync(new PacketStoreWeightLimitNotify());
            await SendPacketAsync(new PacketPlayerStoreNotify(this));
            await SendPacketAsync(new PacketAvatarDataNotify(this));
            await SendPacketAsync(new PacketAllWidgetDataNotify(this)); //TODO
            await SendPacketAsync(new PacketWidgetGadgetAllDataNotify()); //TODO

            // Create world
            World.World world = new(this);
            if (SceneId == 0 || Position == new Vector3(0, 0, 0)) // new player?
            {
                SceneId = 3;
                WorldAreaIds = Tuple.Create<uint, uint>(1, 109); // beach
                await EnterWorldAreaAsync(1, 1, true);
                await world.AddPlayerAsync(this, EnterReason.Login, EnterType.Self, true);
            }
            else
                await world.AddPlayerAsync(this, EnterReason.Login);

            // Multiplayer setting
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_PLAYER_MP_SETTING_TYPE, (int)MpSettingType.EnterAfterApply, false);
            await PropManager.SetPropertyAsync(PlayerProperty.PROP_IS_MP_MODE_AVAILABLE, 1, false);

            await ResinManager.OnLoginAsync();

            // First notify packets sent
            HasSentLoginPackets = true;
            Session.State = SessionState.ACTIVE;
        }

        public async Task OnLogoutAsync()
        {
            // Leave world
            if (World != null)
            {
                await World.RemovePlayerAsync(this);
            }

            await Task.WhenAll(new Task[] {
                    DatabaseManager.SavePlayerAsync(this),
                    DatabaseManager.SaveAvatarsAsync(Avatars),
                    DatabaseManager.SaveInventoryAsync(Inventory),
                    DatabaseManager.SaveProgressAsync(ProgressManager),
                    DatabaseManager.SaveShopsAsync(ShopManager),
                    DatabaseManager.SaveSocialAsync(SocialManager),
                    DatabaseManager.SaveTeamsAsync(TeamManager),
                });
            GameServer.OnlinePlayers.Remove(GameUid);
        }

        // Called by DatabaseManager
        public async Task OnLoadAsync()
        {
            Task.Yield();
            PropManager = new(this);
            ResinManager = new(this);
            ExpManager = new(this);
            BattlePassManager = new(this);
            MapMarksManager = new(this);
            GadgetManager = new(this);
            EnergyManager = new(this);
            OpenStateManager = new(this);
            StaminaManager = new(this);
            CombatInvNotifyList = new(this, typeof(PacketCombatInvocationsNotify));
            AbilityInvNotifyList = new(this, typeof(PacketAbilityInvocationsNotify));
            ClientAbilityInitFinishNotifyList = new(this, typeof(PacketClientAbilityInitFinishNotify));
        }

        //TODO
        public void SetPaused(bool newPauseState)
        {
            bool oldPauseState = Paused;
            Paused = newPauseState;

            if (newPauseState && !oldPauseState)
            {
                //StaminaManager.StopSustainedStaminaHandler();
            }
            else if (oldPauseState && !newPauseState)
            {
                //StaminaManager.StartSustainedStaminaHandler();
            }
        }

        public OnlinePlayerInfo GetOnlinePlayerInfo()
        {
            OnlinePlayerInfo onlineInfo = new()
            {
                Uid = (uint)GameUid,
                Nickname = Profile.Nickname,
                PlayerLevel = (uint)PlayerProperties[PlayerProperty.PROP_PLAYER_LEVEL],
                MpSettingType = (MpSettingType)PlayerProperties[PlayerProperty.PROP_PLAYER_MP_SETTING_TYPE],
                NameCardId = (uint)Profile.NameCardId,
                Signature = Profile.Signature,
                ProfilePicture = Profile.HeadImage,
                //AvatarId = (uint)TeamManager.Teams[TeamManager.CurrentTeamIndex].AvatarInfo[TeamManager.CurrentCharacterIndex].AvatarId, // current selected avatar
                //OnlineId = AccountUid, // not sure if correct
                //PsnId = 42069,
                //WorldLevel = (uint)Profile.WorldLevel
            };

            if (World != null)
            {
                onlineInfo.CurPlayerNumInWorld = (uint)World.Players.Count;
            }
            if (Profile.BlacklistUidList != null)
                onlineInfo.BlacklistUidList.AddRange(Profile.BlacklistUidList);

            return onlineInfo;
        }
        public async Task SendPacketAsync(BasePacket packet)
        {
            await Session.SendPacketAsync(packet);
        }
    }
}
