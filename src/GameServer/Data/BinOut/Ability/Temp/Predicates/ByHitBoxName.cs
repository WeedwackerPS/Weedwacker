using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByHitBoxName : BasePredicate
    {
        [JsonProperty] public readonly string[] hitBoxNames;
    }
}
