using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetSkillCanUseInStateMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int[] skillList;
        [JsonProperty] public readonly string[] stateList;
    }
}
