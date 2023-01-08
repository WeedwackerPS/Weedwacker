using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigMoveSmoothedSpeed : ConfigMove
    {
        [JsonProperty] public readonly float maxSpeed;
        [JsonProperty] public readonly float accelerationXz;
        [JsonProperty] public readonly float accelerationY;
        [JsonProperty] public readonly float zeroingSpeedXz;
        [JsonProperty] public readonly float zeroingSpeedY;
    }
}
