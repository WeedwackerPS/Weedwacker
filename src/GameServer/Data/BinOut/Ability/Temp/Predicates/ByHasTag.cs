using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByHasTag : BasePredicate
    {
        [JsonProperty] public readonly string tag;
    }
}
