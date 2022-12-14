using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ModifyAvatarSkillCD : ConfigAbilityAction
    {
        [JsonProperty] public readonly BasePredicate[] predicates;
        [JsonProperty] public readonly int overtime;
        [JsonProperty] public readonly float cdRatio;
    }
}
