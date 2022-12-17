using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttackCostElementMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string strikeType;
        [JsonProperty] public readonly float strikeCostRatio;
        [JsonProperty] public readonly ElementType costElementType;
        [JsonProperty] public readonly string costType;
    }
}
