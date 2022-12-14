using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetAISkillCDAvailableNow : ConfigAbilityAction
    {
        [JsonProperty] public readonly int[] skillIDs;
    }
}
