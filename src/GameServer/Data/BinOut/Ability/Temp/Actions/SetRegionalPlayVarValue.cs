using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetRegionalPlayVarValue : ConfigAbilityAction
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly string varType;
        [JsonProperty] public readonly int varValue;
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
