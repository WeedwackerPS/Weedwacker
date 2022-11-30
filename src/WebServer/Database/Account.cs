using Weedwacker.Shared.Utils;

namespace Weedwacker.WebServer.Database
{
    public class Account
    {
        public string Id { get; private set; } // WebServer unique Id. Number, but sent as a string...

        /*@Indexed(options = @IndexOptions(unique = true))
        @Collation(locale = "simple", caseLevel = true)
        */
        public string Username { get; private set; }
        public string Password; // Unused for now
        public string Email { get; private set; }

        public string Token { get; private set; }
        public string SessionKey { get; private set; } // Session token for dispatch server
        public List<string> Permissions;
        public System.Globalization.CultureInfo Locale;

        private string BanReason;
        private int BanEndTime;
        private int BanStartTime;
        private bool IsBanned;

        public List<GameAccount> GameAccounts;

        public class GameAccount
        {
            public int uid { get; private set; }
        }


        public Account(string username, string id)
        {
            Username = username;
            Id = id;
        }
        public async Task save()
        {
            await DatabaseManager.SaveAccount(this);
        }

        public async Task<string> GenerateSessionKey()
        {
            SessionKey = BitConverter.ToString(Crypto.CreateSessionKey(32)).Replace("-", string.Empty);
            await save();
            return SessionKey;
        }

        public async Task<string> GenerateLoginToken()
        {
            Token = BitConverter.ToString(Crypto.CreateSessionKey(32)).Replace("-", string.Empty);
            await save();
            return Token;
        }
    }
}
