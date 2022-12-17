using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class HideAvatarSkillMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int[] skillID;
    }
}
