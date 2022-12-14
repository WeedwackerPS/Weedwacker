using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class OnAvatarUseSkillMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ConfigAbilityAction[] onTriggerSkill;
        [JsonProperty] public readonly float clearSkillIdDelay;
    }
}
