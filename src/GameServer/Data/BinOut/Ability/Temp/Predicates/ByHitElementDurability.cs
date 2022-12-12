using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByHitElementDurability : BasePredicate
    {
        [JsonProperty] public readonly ElementType element;
        [JsonProperty] public readonly int durability;
        [JsonProperty] public readonly CompareType compareType;
    }
}
