using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByEnergy : BasePredicate
    {
        [JsonProperty] public readonly float value;
        [JsonProperty] public readonly LogicType logic;
    }
}
