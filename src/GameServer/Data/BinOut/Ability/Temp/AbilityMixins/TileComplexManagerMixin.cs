using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class TileComplexManagerMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string attackID;
        [JsonProperty] public readonly float interval;
        [JsonProperty] public readonly ConfigAttackInfo attackInfo;
    }
}
