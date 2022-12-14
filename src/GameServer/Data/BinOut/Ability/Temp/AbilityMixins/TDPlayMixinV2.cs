using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class TDPlayMixinV2 : BaseAbilityMixin
    {
        [JsonProperty] public readonly TowerType towerType;
        [JsonProperty] public readonly int baseCD;
        [JsonProperty] public readonly int baseAttackRange;
        [JsonProperty] public readonly int bulletID;
        [JsonProperty] public readonly BaseBornType born;
        [JsonProperty] public readonly ConfigAbilityAction[] onFireActions;
    }
}
