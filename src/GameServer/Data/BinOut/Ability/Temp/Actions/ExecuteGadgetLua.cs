using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ExecuteGadgetLua : ConfigAbilityAction
    {
        [JsonProperty] public readonly string target;
        [JsonProperty] public readonly int param1;
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
