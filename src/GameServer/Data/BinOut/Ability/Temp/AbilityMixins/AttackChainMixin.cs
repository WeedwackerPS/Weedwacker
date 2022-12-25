using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttackChainMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly object? cd;
        [JsonProperty] public readonly ReactionType[] reactionTypes;
        [JsonProperty] public readonly string[] attackTags;
        [JsonProperty] public readonly string effectName;
        [JsonProperty] public readonly string effectAttachPoint;
        [JsonProperty] public readonly float lineRange;
        [JsonProperty] public readonly string attackChainReceiverKey;
    }
}
