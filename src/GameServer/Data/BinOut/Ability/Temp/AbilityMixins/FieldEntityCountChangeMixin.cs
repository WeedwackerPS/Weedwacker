using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class FieldEntityCountChangeMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly TargetType campTargetType;
        [JsonProperty] public readonly BasePredicate[] targetPredicates;
        [JsonProperty] public readonly ConfigAbilityAction[] onFieldEnter;
        [JsonProperty] public readonly ConfigAbilityAction[] onFieldExit;

    }
}
