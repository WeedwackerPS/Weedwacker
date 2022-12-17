using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ModifyCameraMaxDistanceMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int MaxDistance;
        [JsonProperty] public readonly bool ResetToMaxOnStart;
        [JsonProperty] public readonly float LerpInDuration;
        [JsonProperty] public readonly float LerpOutDuration;
    }
}
