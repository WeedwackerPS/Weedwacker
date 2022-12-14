using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AddElementDurability : ConfigAbilityAction
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly bool doOffStage;
        [JsonProperty] public readonly object value;
        [JsonProperty] public readonly BasePredicate[]? predicates;
        [JsonProperty] public readonly string modifierName;
        [JsonProperty] public readonly bool useLimitRange;
        [JsonProperty] public readonly object maxValue;
        [JsonProperty] public readonly float minValue;
    }
}
