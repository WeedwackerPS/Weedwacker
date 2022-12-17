using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByHasShield : BasePredicate
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly TargetType type;
    }
}
