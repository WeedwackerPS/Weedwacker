using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByAvatarIsHost : BasePredicate
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly bool isHost;
    }
}
