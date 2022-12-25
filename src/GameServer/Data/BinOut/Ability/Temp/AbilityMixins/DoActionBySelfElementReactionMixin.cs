using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoActionBySelfElementReactionMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ReactionType[] reactionTypes;
        [JsonProperty] public readonly ConfigAbilityAction[] actionQueue;
    }
}
