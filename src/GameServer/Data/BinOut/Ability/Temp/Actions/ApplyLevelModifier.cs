using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ApplyLevelModifier : ConfigAbilityAction
    {
        [JsonProperty] public readonly string modifierName;
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
