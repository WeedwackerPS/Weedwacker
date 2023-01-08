using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared
{
    internal abstract class ConfigBornType
    {
        [JsonProperty] public readonly OffSet? offset;
        public class OffSet
        {
            [JsonProperty] public readonly object x;
            [JsonProperty] public readonly object y;
            [JsonProperty] public readonly object z;
        }
    }
}
