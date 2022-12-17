using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AttackPatterns
{
    internal class ConfigAttackBox : BaseAttackPattern
    {
        [JsonProperty] public readonly bool filterByFrame;
        [JsonProperty] public readonly Size size;

        public class Size
        {
            [JsonProperty] public readonly object x;
            [JsonProperty] public readonly object y;
            [JsonProperty] public readonly object z;
        }
    }
}
