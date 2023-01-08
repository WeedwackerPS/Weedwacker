using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigSurroundBulletMove : ConfigBulletMove
    {
        [JsonProperty] public readonly bool clockwise;
        [JsonProperty] public readonly float radius;
        [JsonProperty] public readonly bool traceOnYAxis;
        [JsonProperty] public readonly bool destroyWhenTargetDie;
    }
}
