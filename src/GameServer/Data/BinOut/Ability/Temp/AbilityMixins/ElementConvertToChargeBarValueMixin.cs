using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ElementConvertToChargeBarValueMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string group;
    }
}
