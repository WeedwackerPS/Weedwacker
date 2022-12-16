using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ClampDamageReceivedMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string clampType;
        [JsonProperty] public readonly float maxValue;
    }
}
