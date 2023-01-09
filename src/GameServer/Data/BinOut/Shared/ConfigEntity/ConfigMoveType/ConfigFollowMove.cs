using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigFollowMove : ConfigMove
    {
        [JsonProperty] public readonly FollowTarget target;
        [JsonProperty] public readonly int groupTargetInstanceId;
        [JsonProperty] public readonly string attachPoint;
        [JsonProperty] public readonly bool followRotation;
        [JsonProperty] public readonly Vector offset;
        [JsonProperty] public readonly Vector forward;
        [JsonProperty] public readonly bool followOwnerInvisible;
        [JsonProperty] public readonly float fixedY;
        [JsonProperty] public readonly ConfigIgnoreCollision ignoreCollision;
        [JsonProperty] public readonly ConfigMoveDisableCollision moveDisableCollision;
        [JsonProperty] public readonly ConfigMoveAudio moveAudio;
        [JsonProperty] public readonly bool syncTransToServer;
        [JsonProperty] public readonly float syncInterval;
        [JsonProperty] public readonly bool handleInLateTick;

        public class ConfigIgnoreCollision
        {
            [JsonProperty] public readonly ConfigEntityCollider[] selfColliders;
            [JsonProperty] public readonly ConfigEntityCollider[] targetCollides;
        }

        public class ConfigEntityCollider
        {
            [JsonProperty] public readonly EntityColliderType type;
        }

        public class ConfigMoveDisableCollision
        {
            [JsonProperty] public readonly ConfigEntityCollider[] selfColliders;
            [JsonProperty] public readonly float delayEnableTime;
        }

        public class ConfigMoveAudio
        {
            [JsonProperty] public readonly ConfigWwiseString startEvent;
            [JsonProperty] public readonly ConfigWwiseString stopEvent;
            [JsonProperty] public readonly ConfigWwiseString moveStateParam;
            [JsonProperty] public readonly ConfigWwiseString fallOnGroundEvent;
        }
    }
}
