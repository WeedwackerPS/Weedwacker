using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByAnimatorFloat : BasePredicate
    {
        [JsonProperty] public readonly string parameter;
        [JsonProperty] public readonly float value;
        [JsonProperty] public readonly LogicType logic;
    }
}
