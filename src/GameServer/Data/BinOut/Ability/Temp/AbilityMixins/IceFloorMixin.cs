using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class IceFloorMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly float width;
        [JsonProperty] public readonly float height;
        [JsonProperty] public readonly ConfigAbilityAction doAction;
    }
}
