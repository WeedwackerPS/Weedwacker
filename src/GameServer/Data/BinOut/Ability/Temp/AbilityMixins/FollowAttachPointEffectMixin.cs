using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class FollowAttachPointEffectMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string modifierName;
        [JsonProperty] public readonly string attachPriority;
        [JsonProperty] public readonly bool refreshOnAvatarIn;
    }
}
