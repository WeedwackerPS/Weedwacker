using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class RemoveServerBuff : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool isTeamBuff;
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly int sBuffId;
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
