using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class NahidaHollowFlowerMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string effectPattern;
        [JsonProperty] public readonly string effectTrigger;
        [JsonProperty] public readonly string interval;
        [JsonProperty] public readonly string maxCount;
        [JsonProperty] public readonly string createMaxNumPerInterval;
        [JsonProperty] public readonly string createOffset;
        [JsonProperty] public readonly string maxRange;
        [JsonProperty] public readonly string destroyRange;
    }
}
