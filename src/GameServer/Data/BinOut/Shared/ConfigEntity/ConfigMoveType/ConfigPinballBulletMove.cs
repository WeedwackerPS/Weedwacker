using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigPinballBulletMove : ConfigBulletMove 
    {
        [JsonProperty] public readonly float radius;
        [JsonProperty] public readonly bool traceOnYAxis;
        [JsonProperty] public readonly bool destroyWhenTargetDie;
        [JsonProperty] public readonly float randomBackAngleAdded;
        [JsonProperty] public readonly float reboundInterval;
        [JsonProperty] public readonly float outOfRangeFixCd;
    }
}
