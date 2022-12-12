using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ChargeBarMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ElementType chargeBarElementType;
        [JsonProperty] public readonly int chargeBarIconID;
        [JsonProperty] public readonly int initialValue;
        [JsonProperty] public readonly object maxValue;
    }
}
