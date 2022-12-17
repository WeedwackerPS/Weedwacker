using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoActionByElementReactionMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly EntityType[] entityTypes;
        [JsonProperty] public readonly ReactionType[] reactionTypes;
        [JsonProperty] public readonly ConfigAbilityAction[]? actions;
    }
}
