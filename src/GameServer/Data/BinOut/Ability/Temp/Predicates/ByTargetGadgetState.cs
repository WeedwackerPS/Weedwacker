using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByTargetGadgetState : BasePredicate
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly int gadgetState;
    }
}
