using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoActionByRayTagMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] UGCRayTriggerDirections;
        [JsonProperty] public readonly float raycastInterval;
        [JsonProperty] public readonly int[] rayTags;
        [JsonProperty] public readonly string[] modifierToTags;
    }
}
