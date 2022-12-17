using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class EliteShieldMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string shieldType;
        [JsonProperty] public readonly float shieldAngle;
        [JsonProperty] public readonly object shieldHPRatio;
        [JsonProperty] public readonly object shieldHP;
        [JsonProperty] public readonly string showDamageText;
        [JsonProperty] public readonly ConfigAbilityAction[] onShieldBroken;
    }
}
