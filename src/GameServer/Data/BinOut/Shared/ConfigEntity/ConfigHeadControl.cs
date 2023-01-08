using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity
{
    internal class ConfigHeadControl
    {
        [JsonProperty] public readonly bool useHeadControl;
        [JsonProperty] public readonly float maxYawDegree;
        [JsonProperty] public readonly float maxPitchDegree;
        [JsonProperty] public readonly float speed;
        [JsonProperty] public readonly float weightSpeed;
        [JsonProperty] public readonly bool useWhiteAnimStates;
        [JsonProperty] public readonly string[] animStates;
        [JsonProperty] public readonly string[] dontAnimStates;
    }
}
