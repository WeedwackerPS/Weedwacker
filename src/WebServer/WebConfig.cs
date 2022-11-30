using Newtonsoft.Json;
using Weedwacker.Shared.Utils.Configuration;

namespace Weedwacker.WebServer
{
    internal class WebConfig : ConfigFile
    {
        public KestrelJson Kestrel = new();
        public ServerJson Server = new();
        public DatabaseJson Database = new();

        public class KestrelJson
        {
            [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
            public EndpointsJson Endpoints = new();
            public class EndpointsJson
            {
                public HttpsJson Https = new();
                public HttpJson Http = new();
                public class HttpsJson
                {

                    public CertificateJson Certificate = new();

                    public string Url = "https://127.0.0.1:443";
                    public string ClientCertificateMode = "NoCertificate";
                    public string[] SslProtocols = new string[] { "Tls12", "Tls13" };
                    public class CertificateJson
                    {
                        public string Path = "../../../keystore.p12";
                        public string Password = "123456";
                    }

                }
                public class HttpJson
                {
                    public string Url = "http://127.0.0.1:5000";
                }
            }
        }

        public new class DatabaseJson
        {
            public string ConnectionUri = "mongodb://localhost:27017";
            public string Database = "weedwackerWeb";
        }

        public class ServerJson
        {
            public bool EnforceEncryption = true;
            public bool LogCommands = false;
            public PoliciesJson Policies = new();
            public FilesJson Files = new();
            public AccountJson Account = new();
            public Shared.Enums.ServerDebugMode LogPackets = Shared.Enums.ServerDebugMode.NONE;
            public DispatchJson Dispatch = new();


            public class AccountJson
            {
                public bool UsePassword = false;
                public bool AutoCreate = false;
                public string[] DefaultPermissions = Array.Empty<string>();
                public int MaxAccount = -1;
            }
        }


        /* Data containers. */

        public class DispatchJson
        {
            [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
            public List<Region> Regions = new() { new Region() };
            public string DefaultName = "Weedwacker";

        }

        public class PoliciesJson
        {
            public CORS Cors = new CORS();

            public class CORS
            {
                public bool Enabled = false;
                public string[] AllowedOrigins = new string[] { "*" };
            }
        }

        public class FilesJson
        {
            public string IndexFile = "./index.html";
            public string ErrorFile = "./404.html";
        }

    }
}
