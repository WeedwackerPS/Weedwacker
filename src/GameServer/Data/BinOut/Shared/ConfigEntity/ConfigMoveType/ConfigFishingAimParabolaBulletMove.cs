using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigFishingAimParabolaBulletMove : ConfigBulletMove
    {
        [JsonProperty] public readonly float gravity;
        [JsonProperty] public readonly float initSpeed;
        [JsonProperty] public readonly string globalValueKey;
    }
}
