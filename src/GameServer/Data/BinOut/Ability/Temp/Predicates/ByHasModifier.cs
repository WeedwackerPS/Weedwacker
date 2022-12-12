using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByHasModifier : BasePredicate
    {
        [JsonProperty] public readonly string modifierName;
    }
}
