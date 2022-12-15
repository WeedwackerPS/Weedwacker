using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class EntityDitherMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly BasePredicate[] predicates;
        [JsonProperty] public readonly float ditherValue;
        [JsonProperty] public readonly float cutInTime;
        [JsonProperty] public readonly float cutOutTime;
    }
}
