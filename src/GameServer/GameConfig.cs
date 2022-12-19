using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;
using Weedwacker.Shared.Utils.Configuration;

namespace Weedwacker.GameServer
{
    internal class GameConfig : ConfigFile
    {
        public ServerJson Server = new();
        public DatabaseJson Database = new();
        public new StructureJson structure = new();
        public new class DatabaseJson
        {
            public string ConnectionUri = "mongodb://localhost:27017";
            public string Database = "weedwackerGame";
        }
        public new class StructureJson
        {
            public string Resources = "..\\..\\..\\resources\\";
            public string Scripts = "..\\..\\..\\resources\\Scripts\\";
            public string keys = "..\\..\\..\\keys\\";


            // UNUSED (potentially added later?)
            // public String dumps = "./dumps/";
        }
        public class ServerJson
        {
#if DEBUG
            public OpCode[] DebugWhitelist = Array.Empty<OpCode>();
            public OpCode[] DebugBlacklist = new[] {
                OpCode.PingReq, OpCode.PingRsp, OpCode.PlayerSetPauseReq, OpCode.PlayerSetPauseRsp, OpCode.AbilityInvocationsNotify,
                OpCode.WorldPlayerRTTNotify, OpCode.PlayerTimeNotify, OpCode.UnionCmdNotify, OpCode.CombatInvocationsNotify,
                OpCode.ClientAbilityChangeNotify,
            };
            public bool KeepLog = true;
            public bool ShowPacketInWeb = true;
            public string PacketRecordRoot = "..\\..\\..\\PacketRecorderRoot\\";
            public string LogLocation = ".\\packetLogs";
            public bool LogCombatInvocations = true;
            public CombatTypeArgument[] CombatArgTypeBlacklist = new[] { CombatTypeArgument.EntityMove };
            public bool LogAbilityInvocations = true;
            public AbilityInvokeArgument[] AbilityInvArgBlacklist = new[] { AbilityInvokeArgument.MetaModifierDurabilityChange };
#endif
            /* This is the address used in the default region. */
            public string AccessAddress = "127.0.0.1";
            /* This is the port used in the default region. */
            public int AccessPort = 22102;

            public int MaxOnlinePlayers = 1000;
            /* Entities within a certain range will be loaded for the player */
            public int LoadEntitiesForPlayerRange = 100;
            public bool EnableConsole = true;

            /* Determines whether each scene's scripts will be loaded on startup, or when needed. Scene3 scripts are always loaded*/
            public bool DynamicLoadScenes = true;
            /* Controls whether packets should be logged in console or not */
            public Shared.Enums.ServerDebugMode LogPackets = Shared.Enums.ServerDebugMode.BLACKLIST;

            /* needed for authentication, and for some game systems */
            public string WebServerUrl = "https://127.0.0.1";

            public GameOptions GameOptions = new GameOptions();
            public JoinOptions JoinOptions = new JoinOptions();
            public ConsoleAccount ServerAccount = new ConsoleAccount();
        }

        /* Data containers. */


        public class GameOptions
        {
            public InventoryLimitsJson InventoryLimits = new();
            public AvatarLimitsJson AvatarLimits = new();
            public int SceneEntityLimit = 1000; // Unenforced. TODO: Implement.

            public bool WatchGachaConfig = false;
            public bool EnableShopItems = true;
            public bool StaminaUsage = true;
            public bool EnergyUsage = true;
            public bool FishhookTeleport = true;
            public ResinOptionsJson ResinOptions = new();
            public RatesJson Rates = new();
            public ConstantsJson Constants = new();

            public class ConstantsJson
            {
                public string VERSION = "3.0.0";

                public int DEFAULT_TEAMS = 4;
                public int MAX_TEAMS = 10;

                public int MAX_FRIENDS = 45;
                public int MAX_FRIEND_REQUESTS = 50;

                public int SERVER_CONSOLE_UID = 99; // The UID of the server console's "player".

                public int BATTLE_PASS_MAX_LEVEL = 50;
                public int BATTLE_PASS_POINT_PER_LEVEL = 1000;
                public int BATTLE_PASS_POINT_PER_WEEK = 10000;
                public int BATTLE_PASS_LEVEL_PRICE = 150;
                public int BATTLE_PASS_CURRENT_INDEX = 2;

                public ulong DEFAULT_ABILITY_NAME = Utils.AbilityHash("Default");
            }

            public class InventoryLimitsJson
            {
                public int Weapons = 2000;
                public int Relics = 2000;
                public int Materials = 2000;
                public int Furniture = 2000;
                public int All = 30000;
            }

            public class AvatarLimitsJson
            {
                public int SinglePlayerTeam = 4;
                public int MultiplayerTeam = 4;
            }

            public class RatesJson
            {
                public float AdventureExp = 1.0f;
                public float Mora = 1.0f;
                public float LeyLines = 1.0f;
            }

            public class ResinOptionsJson
            {
                public bool ResinUsage = true;
                public int Cap = 160;
                public int RechargeTime = 480;
            }
        }

        public class JoinOptions
        {
            public int[] WelcomeEmotes = { 2007, 1002, 4010 };
            public string WelcomeMessage = "Welcome to a Weedwacker server.";
            public Mail WelcomeMail = new Mail();

            public class Mail
            {
                public string Title = "Welcome to Weedwacker!";
                public string Content = "Hi there!\r\nFirst of all, welcome to Weedwacker. If you have any issues, please let us know so that Primrose can help you!";
                public string Sender = "Primrose";
                /*
                public Weedwacker.game.mail.Mail.MailItem[] items = {
                new Weedwacker.game.mail.Mail.MailItem(13509, 1, 1),
                new Weedwacker.game.mail.Mail.MailItem(201, 99999, 1)
                };
                */
            }
        }

        public class ConsoleAccount
        {
            public int AvatarId = 10000007;
            public int NameCardId = 210001;
            public int AdventureRank = 1;
            public int WorldLevel = 0;

            public string NickName = "Server";
            public string Signature = "Welcome to Weedwacker!";
        }


        /* Objects. */

        public new class Region
        {
            public Region() { }

            public Region(
                string name, string title,
                string address, uint port
            )
            {
                Name = name;
                Title = title;
                Ip = address;
                Port = port;
            }

            public string Name = "os_usa";
            public string Title = "Weedwacker";
            public string Ip = "127.0.0.1";
            public uint Port = 22102;
        }
    }
}