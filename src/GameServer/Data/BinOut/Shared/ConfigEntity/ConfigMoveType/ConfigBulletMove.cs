using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigBulletMove : ConfigMove
    {
        [JsonProperty] public readonly float speed;
        [JsonProperty] public readonly float maxSpeed;
        [JsonProperty] public readonly float minSpeed;
        [JsonProperty] public readonly float anglerVelocity;
        [JsonProperty] public readonly float accelerationTime;
        [JsonProperty] public readonly bool canBornInWater;
        [JsonProperty] public readonly ConfigBulletMoveAngle updateAngle;
        [JsonProperty] public readonly float delay;
        [JsonProperty] public readonly ConfigMoveStickToGround stickToGround;
        [JsonProperty] public readonly bool syncToRemote;
        [JsonProperty] public readonly float blockedByMonsterRadius;

        public class ConfigMoveStickToGround
        {
            [JsonProperty] public readonly float maxStepHeight;
            [JsonProperty] public readonly float maxSlopeAngle;
            [JsonProperty] public readonly float heightToGround;
            [JsonProperty] public readonly float flexibleRange;
            [JsonProperty] public readonly bool isStickToWater;
            [JsonProperty] public readonly UnstickAction unstickWhenDownSlide;
            [JsonProperty] public readonly UnstickAction unstickWhenUpSlide;
        }
    }
}
