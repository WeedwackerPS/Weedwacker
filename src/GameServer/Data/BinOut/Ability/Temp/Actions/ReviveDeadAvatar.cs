using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ReviveDeadAvatar : ConfigAbilityAction
    {
        [JsonProperty] public readonly BasePredicate[] predicates;
        [JsonProperty] public readonly object amountByTargetMaxHPRatio;
        [JsonProperty] public readonly bool isReviveOtherPlayerAvatar;
        [JsonProperty] public readonly int overtime;
        [JsonProperty] public readonly float cdRatio;
        [JsonProperty] public readonly float rayCount;
    }
}
