using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class WatcherSystemMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string mixinType;
        [JsonProperty] public readonly int watcherId;
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
