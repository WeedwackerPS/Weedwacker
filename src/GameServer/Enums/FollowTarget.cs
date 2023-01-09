using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum FollowTarget
    {
        LocalAvatar,
        LocalAvatarSyncedLocation,
        LocalAvatarAuthority,
        TargetEntity,
        GroupGadgetEntity,
        GroupMonsterEntity,
        NpcEntity
    }
}
