using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigTrackBulletMove : ConfigBulletMove
    {
        [JsonProperty] public readonly bool destroyWhenTargetDie;
        [JsonProperty] public readonly bool traceOnYAxis;
    }
}
