using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class NahidaHollowFlowerMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string effectPattern;
        [JsonProperty] public readonly string effectTrigger;
        [JsonProperty] public readonly double interval;
        [JsonProperty] public readonly int maxCount;
        [JsonProperty] public readonly int createMaxNumPerInterval;
        [JsonProperty] public readonly object createOffset;
        [JsonProperty] public readonly float maxRange;
        [JsonProperty] public readonly float destroyRange;
    }
}
