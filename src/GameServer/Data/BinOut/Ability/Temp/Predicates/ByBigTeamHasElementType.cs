using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByBigTeamHasElementType : BasePredicate
    {
        [JsonProperty] public readonly ElementType elementType;
        [JsonProperty] public readonly LogicType logic;
        [JsonProperty] public readonly int number;
    }
}
