using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetAISkillCDMultiplier : ConfigAbilityAction
    {
        [JsonProperty] public readonly float multiplier;
    }
}
