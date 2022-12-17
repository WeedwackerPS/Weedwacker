using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoTileActionManagerMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly float duration;
        [JsonProperty] public readonly string actionID;
        [JsonProperty] public readonly string actionPosKey;
        [JsonProperty] public readonly string actionRadiusKey;
        [JsonProperty] public readonly ConfigAbilityAction[] actions;
    }
}
