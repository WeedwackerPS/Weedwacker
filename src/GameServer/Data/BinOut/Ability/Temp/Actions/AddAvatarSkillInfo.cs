using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AddAvatarSkillInfo : ConfigAbilityAction
    {
        [JsonProperty] public readonly int overtime;
    }
}
