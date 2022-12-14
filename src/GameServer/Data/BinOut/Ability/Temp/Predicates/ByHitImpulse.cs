using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByHitImpulse : BasePredicate
    {
        [JsonProperty] public readonly float hitImpulse;
    }
}
