using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigAnimatorMove : ConfigMove
    {
        [JsonProperty] public readonly bool initWithGroundHitCheck;
        [JsonProperty] public readonly ConfigMoveSmoothedSpeed smoothedSpeed;
        [JsonProperty] public readonly bool moveOnGround;
        [JsonProperty] public readonly bool moveOnWater;
        [JsonProperty] public readonly float moveOnWaterDepth;
        [JsonProperty] public readonly FacingMoveType facingMove;
        [JsonProperty] public readonly MonsterSizeType monsterSizeType;
        [JsonProperty] public readonly PositionModifyState positionModifyState;
        [JsonProperty] public readonly Dictionary<int, PositionModifyState> positionModifyStateMap;
        [JsonProperty] public readonly bool destroyRockWhenInit;
        [JsonProperty] public readonly float yawSpeedRatio;
        [JsonProperty] public readonly float velocityRatio;

        public class ConfigMoveSmoothedSpeed
        {
            [JsonProperty] public readonly float maxSpeed;
            [JsonProperty] public readonly float accelerationXz;
            [JsonProperty] public readonly float accelerationY;
            [JsonProperty] public readonly float zeroingSpeedXz;
            [JsonProperty] public readonly float zeroingSpeedY;
        }
    }
}
