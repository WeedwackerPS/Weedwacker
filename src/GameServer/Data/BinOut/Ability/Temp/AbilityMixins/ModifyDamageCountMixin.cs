using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ModifyDamageCountMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] attackTags;
        [JsonProperty] public readonly object damageExtra;
        [JsonProperty] public readonly object maxModifyCount;
        [JsonProperty] public readonly ConfigAbilityAction[] successActions;
        [JsonProperty] public readonly ConfigAbilityAction[] maxCountActions;
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
