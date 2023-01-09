using System.Text;
using System.Timers;
using Newtonsoft.Json;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Authentication;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;
using Weedwacker.Shared.Utils.Configuration;

namespace Weedwacker.GameServer
{
    internal static class GameServer
    {
        private static readonly HttpClientHandler handler = new HttpClientHandler()
        { ServerCertificateCustomValidationCallback = delegate { return true; } };  //ignore ServerCertificate error
        private static readonly HttpClient client = new HttpClient(handler);
        private static System.Timers.Timer? TickTimer;
        public static GameConfig? Configuration;
        public static SortedList<uint, Connection> OnlinePlayers = new(); // <gameUid,connection>
        private static HashSet<World> Worlds = new();
        public static SortedList<uint, AvatarCompiledData> AvatarInfo = new(); // <avatarId,data>
        public static Dictionary<uint, string> AbilityNameHashMap;
        public static async Task<bool> VerifyToken(string accountUid, string token)
        {
            var req = JsonConvert.SerializeObject(new VerifyTokenRequestJson() { uid = accountUid, token = token });
            var contentData = new StringContent(req, Encoding.UTF8, "application/json");
            var rsp = await client.PostAsync(Configuration.Server.WebServerUrl + "/hk4e_global/mdk/shield/api/verify", contentData);
            var result = JsonConvert.DeserializeObject<LoginResultJson>(await rsp.Content.ReadAsStringAsync());
            if (result.message == "OK")
            {
                return true;
            }
            return false;
        }

        internal static void RegisterWorld(World world)
        {
            Worlds.Add(world);
        }

        public static AvatarCompiledData? GetAvatarInfo(uint avatarId)
        {
            if (AvatarInfo.TryGetValue(avatarId, out AvatarCompiledData? avatarInfo))
            {
                return avatarInfo;
            }
            else return null;

        }

        public static async Task Start()
        {
            Configuration = await Config.Load<GameConfig>("GameConfig.json");
#if DEBUG
            if (!Directory.Exists(Configuration.Server.LogLocation))
                Directory.CreateDirectory(Configuration.Server.LogLocation);
            else
            {
                DirectoryInfo di = new DirectoryInfo(Configuration.Server.LogLocation);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
            }
#endif
            await GameData.LoadAllResourcesAsync(Configuration.structure.Resources);
            Crypto.LoadKeys(Configuration.structure.keys);
            await Database.DatabaseManager.Initialize();

            foreach (uint id in GameData.AvatarDataMap.Keys)
            {
                AvatarInfo.Add(id, new AvatarCompiledData(id));
            }
            SetAbilityHashMap();

            // Create a timer with a one second interval.
            TickTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            TickTimer.Elapsed += OnTick;
            TickTimer.AutoReset = true;
            TickTimer.Enabled = true;

            Listener.StartListener();
        }

        private static void SetAbilityHashMap()
        {
            Dictionary<uint, string> hashMap = new();
            foreach (var container in GameData.ConfigAbilityAvatarMap.Values.Concat(GameData.ConfigAbilityActivityMap.Values)
                .Concat(GameData.ConfigAbilityAnimalMap.Values).Concat(GameData.ConfigAbilityChallengeMap.Values).Concat(GameData.ConfigAbilityEquipMap.Values)
                .Concat(GameData.ConfigAbilityGadgetMap.Values).Concat(GameData.ConfigAbilityLevelMap.Values).Concat(GameData.ConfigAbilityMap.Values)
                .Concat(GameData.ConfigAbilityMonsterAffixMap.Values).Concat(GameData.ConfigAbilityMonsterMap.Values).Concat(GameData.ConfigAbilityQATestMap.Values)
                .Concat(GameData.ConfigAbilityQuestMap.Values).Concat(GameData.ConfigAbilityTeamMap.Values))
            {
                foreach (var ability in container)
                {
                    var config = ability.Default;
                    hashMap[Utils.AbilityHash(config.abilityName)] = config.abilityName;
                    if (config.abilitySpecials != null)
                    {
                        foreach (string special in config.abilitySpecials.Keys)
                        {
                            hashMap[Utils.AbilityHash(special)] = special;
                        }
                    }
                    if (config.modifiers != null)
                    {
                        foreach (string modifier in config.modifiers.Keys)
                        {
                            hashMap[Utils.AbilityHash(modifier)] = modifier;
                        }
                    }
                }
            }

            foreach (var config in GameData.ConfigAvatarMap.Values)
            {
                if (config.abilities == null) continue;
                foreach (var ability in config.abilities)
                    hashMap[Utils.AbilityHash(ability.abilityId)] = ability.abilityId;
            }

            foreach (var config in GameData.ConfigGadgetMap.Values)
            {
                if (config.abilities == null) continue;
                foreach (var ability in config.abilities)
                    hashMap[Utils.AbilityHash(ability.abilityId)] = ability.abilityId;
            }
            AbilityNameHashMap = hashMap;
        }

        private static async void OnTick(object? source, ElapsedEventArgs e)
        {
            HashSet<World> toRemove = new();
            try
            {
                // Tick worlds.
                foreach (var world in Worlds)
                {
                    if (await world.OnTickAsync())
                        toRemove.Add(world);
                }

                // Tick players.
                foreach (var player in OnlinePlayers.Values)
                {
                    player.Player.OnTickAsync();
                }
            }
            catch (Exception exc)
            {
                Logger.WriteErrorLine("Tick event error", exc);
            }
        }

        public static int GetShopNextRefreshTime(int shopType)
        {
            //TODO
            return int.MaxValue;
        }

        internal static async Task<SocialDetail?> GetSocialDetailByUid(uint askerUid, uint reqUid)
        {
            SocialDetail socialDetail;
            if (OnlinePlayers.TryGetValue(reqUid, out Connection session))
            {
                return session.Player.SocialManager.GetSocialDetail(askerUid);
            }
            else
            {
                var player = await Database.DatabaseManager.GetPlayerByGameUidAsync(reqUid);
                if (player != null)
                    return player.SocialManager.GetSocialDetail(askerUid);
                else
                    return null;
            }
        }

    }
}
