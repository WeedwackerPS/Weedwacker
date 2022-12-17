using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class RemoveAvatarSkillInfo : ConfigAbilityAction
    {
        [JsonProperty] public readonly int overtime;
    }
}
