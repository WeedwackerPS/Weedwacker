using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    internal abstract class BaseBornType
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
