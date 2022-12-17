using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class BySelfForwardAndTargetPosition : BasePredicate
    {
        [JsonProperty] public readonly float value;
        [JsonProperty] public readonly bool isXZ;
        [JsonProperty] public readonly LogicType logic;
    }
}
