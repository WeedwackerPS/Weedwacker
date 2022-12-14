using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetTargetNumToGlobalValue : ConfigAbilityAction
    {
        [JsonProperty] public readonly BaseSelectTargetType srcOtherTargets;
        [JsonProperty] public readonly BasePredicate[] srcPredicates;
        [JsonProperty] public readonly TargetType dstTarget;
        [JsonProperty] public readonly string key;
    }
}
