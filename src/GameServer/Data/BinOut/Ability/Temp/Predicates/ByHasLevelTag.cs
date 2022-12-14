using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByHasLevelTag : BasePredicate
    {
        [JsonProperty] public readonly int levelTagId;
    }
}
