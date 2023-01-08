using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes
{
    internal class ConfigBornByPredicatePoint : ConfigBornType
    {
        [JsonProperty] public readonly float timeForPredictive;
        [JsonProperty] public readonly bool onGround;
    }
}
