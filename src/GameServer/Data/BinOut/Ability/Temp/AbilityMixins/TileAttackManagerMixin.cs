using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class TileAttackManagerMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string attackID;
        [JsonProperty] public readonly TargetType campType;
        [JsonProperty] public readonly bool authorityHandle;
        [JsonProperty] public readonly float interval;
        [JsonProperty] public readonly ConfigAttackInfo attackInfo;
    }
}
