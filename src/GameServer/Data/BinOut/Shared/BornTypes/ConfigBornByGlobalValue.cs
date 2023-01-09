using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes
{
    internal class ConfigBornByGlobalValue : ConfigBornType
    {
        [JsonProperty] public readonly string positionKey;
        [JsonProperty] public readonly string directionKey;
    }
}
