using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByTrampolineType : BasePredicate
    {
        [JsonProperty] public readonly bool? isExcitedState; 
    }
}
