using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class WindZoneMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string shapeName;
        [JsonProperty] public readonly ConfigBornType born;
        [JsonProperty] public readonly object strength;
        [JsonProperty] public readonly object attenuation;
        [JsonProperty] public readonly float innerRadius;
        [JsonProperty] public readonly TargetType targetType;
        [JsonProperty] public readonly BasePredicate[] predicates;
        [JsonProperty] public readonly string modifierName;
    }
}
