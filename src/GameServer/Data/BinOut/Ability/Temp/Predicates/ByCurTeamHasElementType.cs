using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByCurTeamHasElementType : BasePredicate
    {
        [JsonProperty] public readonly ElementType elementType;
        [JsonProperty] public readonly int number;
        [JsonProperty] public readonly LogicType logic;
    }
}
