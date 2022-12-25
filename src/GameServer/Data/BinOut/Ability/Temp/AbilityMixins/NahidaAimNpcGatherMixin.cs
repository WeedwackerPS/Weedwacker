using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class NahidaAimNpcGatherMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string npcAttachEffect;
        [JsonProperty] public readonly string gatherAttachEffect;
        [JsonProperty] public readonly float detectRangeForNPC;
        [JsonProperty] public readonly float widthForNPC;
        [JsonProperty] public readonly float heightForNPC;
        [JsonProperty] public readonly float detectRangeForGather;
        [JsonProperty] public readonly float widthForGather;
        [JsonProperty] public readonly float heightForGather;
        [JsonProperty] public readonly int gatherMaxCount;
    }
}
