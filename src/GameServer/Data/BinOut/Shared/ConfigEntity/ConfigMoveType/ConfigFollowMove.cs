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
    }
}
