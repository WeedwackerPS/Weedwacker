using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByHasShieldV2 : BasePredicate
    {
        [JsonProperty] public readonly string type;
    }
}
