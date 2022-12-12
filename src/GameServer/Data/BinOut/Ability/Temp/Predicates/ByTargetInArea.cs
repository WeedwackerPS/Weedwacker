using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByTargetInArea : BasePredicate
    {
        [JsonProperty] public readonly string areaLevel;
        [JsonProperty] public readonly int[] areas;
    }
}
