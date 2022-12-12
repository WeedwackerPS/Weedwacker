using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByHasFeatureTag : BasePredicate
    {
        [JsonProperty] public readonly int[] featureTagIDs;
    }
}
