using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class UseSkillEliteSet : ConfigAbilityAction
    {
        [JsonProperty] public readonly int skillEliteSetID;
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
