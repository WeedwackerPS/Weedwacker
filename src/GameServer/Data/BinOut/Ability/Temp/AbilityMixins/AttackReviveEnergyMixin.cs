using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttackReviveEnergyMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] attackTags;
        [JsonProperty] public readonly float maxValue;
        [JsonProperty] public readonly float minValue;
        [JsonProperty] public readonly float addValue;
        [JsonProperty] public readonly ConfigAbilityAction reviveAction;
        [JsonProperty] public readonly Dictionary<ElementType, ConfigAbilityAction> fireEffectActions;
    }
}
