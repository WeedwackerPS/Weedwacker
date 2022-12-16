using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByFindBlinkPointSuccess : BasePredicate
    {
        [JsonProperty] public readonly bool findPointSuccess;
    }
}
