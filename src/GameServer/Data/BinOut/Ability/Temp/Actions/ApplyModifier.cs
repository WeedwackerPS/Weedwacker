using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ApplyModifier : ConfigAbilityAction
    {
        [JsonProperty] public readonly string? target;
        [JsonProperty] public readonly bool doOffStage;
        [JsonProperty] public readonly bool? RotationDampTime;
        [JsonProperty] public readonly BaseSelectTargetType? otherTargets;
        [JsonProperty] public readonly string modifierName;
        [JsonProperty] public readonly BasePredicate[]? predicates;
    }
}
