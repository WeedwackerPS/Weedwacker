using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AvatarShareCDSkillStart : ConfigAbilityAction
    {
        [JsonProperty] public readonly int skillID;
        [JsonProperty] public readonly int shareCDType;
    }
}
