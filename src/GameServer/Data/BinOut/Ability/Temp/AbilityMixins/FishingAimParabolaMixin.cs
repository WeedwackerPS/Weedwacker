using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class FishingAimParabolaMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string globalValueKey;
        [JsonProperty] public readonly float minAngle;
        [JsonProperty] public readonly float maxAngle;
        [JsonProperty] public readonly float minRange;
        [JsonProperty] public readonly float maxRange;
        [JsonProperty] public readonly BaseSelectTargetType otherTargets;
    }
}
