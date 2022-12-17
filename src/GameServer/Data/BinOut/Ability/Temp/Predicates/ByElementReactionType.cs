using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByElementReactionType : BasePredicate
    {
        [JsonProperty] public readonly ReactionType reactionType;
    }
}
