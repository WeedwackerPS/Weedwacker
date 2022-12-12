using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class FireEffectFirework : BaseAction
    {
        [JsonProperty] public readonly string effectPattern;
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
