

namespace Weedwacker.Shared.Utils.Configuration
{
    public class ConfigFile
    {
        public StructureJson structure = new();
        public Language language = new();
        public string version = "1.1";

        public abstract class DatabaseJson
        {
            public string connectionUri;
            public string database;
        }
        public class StructureJson
        {
            public string data = "../../../data/";
            public string plugins = "../../../plugins/";
            public string keys = "../../../keys/";

            // UNUSED (potentially added later?)
            // public String dumps = "./dumps/";
        }

        public class Language
        {
            public System.Globalization.CultureInfo language = System.Globalization.CultureInfo.CurrentCulture;
            public System.Globalization.CultureInfo fallback = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            public string document = "EN";
        }


        /* Objects. */

        public class Region
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
