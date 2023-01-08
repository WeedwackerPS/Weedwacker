using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigPlatformMove : ConfigMove
    {
        [JsonProperty] public readonly float avatarTriggerEventDistance;
        [JsonProperty] public readonly bool isMovingWater;
        [JsonProperty] public readonly ConfigRoute route;
        [JsonProperty] public readonly MovePlatformDelayType delayType;
    }
}
