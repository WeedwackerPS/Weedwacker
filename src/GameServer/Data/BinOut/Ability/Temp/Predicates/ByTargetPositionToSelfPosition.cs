using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByTargetPositionToSelfPosition : BasePredicate
    {
        [JsonProperty] public readonly LogicType logic;
        [JsonProperty] public readonly CompareType? compareType;
        [JsonProperty] public readonly object value;
    }
}
