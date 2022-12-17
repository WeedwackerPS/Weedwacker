using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetAnimatorTrigger : ConfigAbilityAction
    {
        [JsonProperty] public readonly BasePredicate[]? predicates;
        [JsonProperty] public readonly string triggerID;
    }
}
