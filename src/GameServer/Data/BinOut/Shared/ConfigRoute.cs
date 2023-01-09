using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared
{
    internal class ConfigRoute
    {
        [JsonProperty] public readonly int localId;
        [JsonProperty] public readonly string name;
        [JsonProperty] public readonly RouteType type;
        [JsonProperty] public readonly bool isForward;
        [JsonProperty] public readonly ConfigWaypoint[] points;
        [JsonProperty] public readonly RotType rotType;
        [JsonProperty] public readonly RotAngleType rotAngleType;
        [JsonProperty] public readonly float arriveRange;

        public class ConfigWaypoint
        {
            [JsonProperty] public readonly Vector pos;
            [JsonProperty] public readonly float waitTime;
            [JsonProperty] public readonly float moveAngularSpeed;
            [JsonProperty] public readonly float waitAngularSpeed;
            [JsonProperty] public readonly float moveRotateRound;
            [JsonProperty] public readonly float waitRotateRound;
            [JsonProperty] public readonly bool stopWaitRotate;
            [JsonProperty] public readonly int speedLevel;
            [JsonProperty] public readonly float targetVelocity;
            [JsonProperty] public readonly bool hasReachEvent;
            [JsonProperty] public readonly float rotAngleMoveSpeed;
            [JsonProperty] public readonly float rotAngleWaitSpeed;
            [JsonProperty] public readonly bool rotAngleSameStop;
            [JsonProperty] public readonly Vector rotRoundReachDir;
            [JsonProperty] public readonly int rotRoundReachRounds;
            [JsonProperty] public readonly Vector rotRoundLeaveDir;
            [JsonProperty] public readonly int rotRoundWaitRounds;
            [JsonProperty] public readonly bool reachStop;
        }
    }
}
