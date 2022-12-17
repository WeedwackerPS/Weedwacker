using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByScenePropState : BasePredicate
    {
        [JsonProperty] public readonly EntityType entityType;
        [JsonProperty] public readonly string state;
    }
}
