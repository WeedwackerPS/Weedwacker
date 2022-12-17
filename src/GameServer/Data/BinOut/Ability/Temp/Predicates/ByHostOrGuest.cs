using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByHostOrGuest : BasePredicate
    {
        [JsonProperty] public readonly bool isHost;
    }
}
