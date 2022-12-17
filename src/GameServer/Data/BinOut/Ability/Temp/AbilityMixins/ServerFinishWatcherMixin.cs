using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ServerFinishWatcherMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int watcherId;
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
