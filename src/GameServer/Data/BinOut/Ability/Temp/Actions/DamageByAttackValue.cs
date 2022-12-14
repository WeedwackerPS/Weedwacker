using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class DamageByAttackValue : ConfigAbilityAction
    {
        [JsonProperty] public readonly string target;
        [JsonProperty] public readonly BaseSelectTargetType? otherTargets;
        [JsonProperty] public readonly BasePredicate[] predicates;
        [JsonProperty] public readonly BaseBornType? born;
        [JsonProperty] public readonly AttackInfo attackInfo;
    }
}