using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByAttackNotHitScene : BasePredicate
    {
        [JsonProperty] public readonly BaseAttackPattern attackPattern;
    }
}
