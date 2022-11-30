using MongoDB.Driver;
using Weedwacker.Shared.Utils;

namespace Weedwacker.WebServer.Database
{
    internal class DatabaseManager
    {
        static MongoClient DbClient;
        static IMongoDatabase Database;
        static IMongoCollection<Account> Accounts;
        static DatabaseProperties Properties;
        public static void Initialize()
        {
            DbClient = new MongoClient(WebServer.Configuration.Database.ConnectionUri);
            // Databases and collections are implicitly created
            Database = DbClient.GetDatabase(WebServer.Configuration.Database.Database);
            Accounts = Database.GetCollection<Account>("accounts");

            if (Database.GetCollection<DatabaseProperties>("dbProperties").Find(w => true).FirstOrDefault() == null)
            {
                Properties = new();
                Database.GetCollection<DatabaseProperties>("dbProperties").InsertOne(Properties);
            }
            else
            {
                Properties = Database.GetCollection<DatabaseProperties>("dbProperties").Find(w => true).First();
            }
            Logger.WriteLine("Connected to WebServer database");
        }


        public static Account? CreateAccountWithUid(string username,string password=null, string uid = "0")
        {
            //Make sure there are no name or id collisions
            var queryResult = Accounts.Find(w => w.Username == username || w.Id == uid);
            if (queryResult.ToList().Count > 0)
            {
                return null;
            }

            // Account
            var newUid = uid;
            if (uid == Properties.NextUid || uid == "0")
            {
                //Increment the counter
                var filter = Builders<DatabaseProperties>.Filter.Eq(x => x.NextUid, Properties.NextUid); // All the documents with (NextUid = Properties.NextUid)
                newUid = (int.Parse(Properties.NextUid) + 1).ToString();
                var update = Builders<DatabaseProperties>.Update.Set(x => x.NextUid, newUid); // Increment counter by 1

                Database.GetCollection<DatabaseProperties>("dbProperties").UpdateOne(filter, update);
                Properties.NextUid = (int.Parse(Properties.NextUid) + 1).ToString();
            }
            Account account = new(username, newUid);
            if (!string.IsNullOrEmpty(password))
            {
                account.Password = password;
            }
            Accounts.InsertOne(account);
            return account;
        }

        public static async Task SaveAccount(Account account)
        {
            // Replaces the account document.
            await Accounts.ReplaceOneAsync<Account>(w => w.Username == account.Username, account);
        }

        public static void UpdateAccount(string field, params string[] args)
        {

        }

        public static async Task<Account?> GetAccountByIdAsync(string uid)
        {
            var matches = await Accounts.FindAsync(w => w.Id == uid);
            return matches.FirstOrDefault();
        }

        public static async Task<Account?> GetAccountByNameAsync(string name)
        {
            var matches = await Accounts.FindAsync(w => w.Username == name);
            return matches.FirstOrDefault();
        }
        public static async Task<Account> GetAccountBySessionKeyAsync(string sessionKey)
        {
            var matches = await Accounts.FindAsync(w => w.SessionKey == sessionKey);
            return matches.FirstOrDefault();
        }
    }
}
