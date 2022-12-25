using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class SwitchSkillIconMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int skillID;
        [JsonProperty] public readonly string skillIcon;
    }
}
