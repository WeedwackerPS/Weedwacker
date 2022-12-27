using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AvatarStrafeMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly StrafeConfig[] configList;

        internal class StrafeConfig
        {
            [JsonProperty] public readonly string[] stateIds;
            [JsonProperty] public readonly float? strafeMoveSpeed;
            [JsonProperty] public readonly bool? rotateToTarget;
            [JsonProperty] public readonly bool? useGravity;
            [JsonProperty] public readonly bool? useRootMotion;
            [JsonProperty] public readonly float? angularSpeed;
        }
    }
}
