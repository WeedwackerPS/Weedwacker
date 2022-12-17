using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetAISkillGCD : ConfigAbilityAction
    {
        [JsonProperty] public readonly float value;
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
