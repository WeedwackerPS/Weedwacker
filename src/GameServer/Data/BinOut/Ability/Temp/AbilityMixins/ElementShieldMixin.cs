using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ElementShieldMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ElementType elementType;
        [JsonProperty] public readonly float shieldHPRatio;
        [JsonProperty] public readonly object damageRatio;
    }
}
