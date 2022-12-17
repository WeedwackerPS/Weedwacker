using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByIsGadgetExistAround : BasePredicate
    {
        [JsonProperty] public readonly int[] gadgetIdArray;
        [JsonProperty] public readonly bool trunToTarget;
    }
}
