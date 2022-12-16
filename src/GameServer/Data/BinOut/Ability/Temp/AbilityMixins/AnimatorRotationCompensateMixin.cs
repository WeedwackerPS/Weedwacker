using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AnimatorRotationCompensateMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] animatorStateIDs;
        [JsonProperty] public readonly float animationRotate;
        [JsonProperty] public readonly float angleLimit;
    }
}
