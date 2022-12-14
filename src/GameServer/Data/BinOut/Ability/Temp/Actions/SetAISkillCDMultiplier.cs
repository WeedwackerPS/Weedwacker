using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetAISkillCDMultiplier : BaseAction
    {
        [JsonProperty] public readonly float multiplier;
    }
}
