using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class Predicated : ConfigAbilityAction
    {
        [JsonProperty] public readonly BasePredicate[] targetPredicates;
        [JsonProperty] public readonly ConfigAbilityAction[] successActions;
        [JsonProperty] public readonly ConfigAbilityAction[] failActions;
    }
}
