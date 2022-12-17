using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByTargetLayoutArea : BasePredicate
    {
        [JsonProperty] public readonly ClimateType climateType;
    }
}
