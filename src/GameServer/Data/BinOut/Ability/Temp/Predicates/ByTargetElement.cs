using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByTargetElement : BasePredicate
    {
        [JsonProperty] public readonly ElementType elementType;
    }
}
