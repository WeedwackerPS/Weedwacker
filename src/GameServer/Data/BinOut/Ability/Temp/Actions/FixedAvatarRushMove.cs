using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class FixedAvatarRushMove : ConfigAbilityAction
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly ConfigBornType toPos;
        [JsonProperty] public readonly float timeRange;
        [JsonProperty] public readonly float maxRange;
        [JsonProperty] public readonly string[] animatorStateIDs;
        [JsonProperty] public readonly string overrideMoveCollider;
        [JsonProperty] public readonly bool isInAir;
    }
}
