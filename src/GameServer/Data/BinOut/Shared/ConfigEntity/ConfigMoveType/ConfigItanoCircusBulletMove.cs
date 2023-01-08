using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigItanoCircusBulletMove : ConfigBulletMove
    {
        [JsonProperty] public readonly float itanoCircusStartAngler;
        [JsonProperty] public readonly bool destroyWhenTargetDie;
        [JsonProperty] public readonly float guidanceDelay;
        [JsonProperty] public readonly bool guidanceSpeedChange;
        [JsonProperty] public readonly float guidanceMinAnglerVelocity;
        [JsonProperty] public readonly float guidanceDuration;
    }
}
