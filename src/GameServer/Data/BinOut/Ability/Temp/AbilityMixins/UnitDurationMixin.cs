using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class UnitDurationMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly bool isTrigger;
        [JsonProperty] public readonly int[] steps;
        [JsonProperty] public readonly string[] modifierName;
    }
}
