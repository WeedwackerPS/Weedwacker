using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class SelfAddDurabilityMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly float value;
        [JsonProperty] public readonly bool useLimitRange;
        [JsonProperty] public readonly float maxValue;
        [JsonProperty] public readonly float thinkInterval;
    }
}
