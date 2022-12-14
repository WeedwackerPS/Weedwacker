using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AvatarSkillStart : ConfigAbilityAction
    {
        [JsonProperty] public readonly int overtime;
        [JsonProperty] public readonly object cdRatio;
        [JsonProperty] public readonly object costStaminaRatio;
    }
}
