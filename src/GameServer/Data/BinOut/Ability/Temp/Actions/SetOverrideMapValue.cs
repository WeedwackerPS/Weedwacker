using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetOverrideMapValue : ConfigAbilityAction
    {
        [JsonProperty] public readonly BaseSelectTargetType otherTargets;
        [JsonProperty] public readonly BasePredicate[] predicates;
        [JsonProperty] public readonly object value;
        [JsonProperty] public readonly string overrideMapKey;
    }
}
