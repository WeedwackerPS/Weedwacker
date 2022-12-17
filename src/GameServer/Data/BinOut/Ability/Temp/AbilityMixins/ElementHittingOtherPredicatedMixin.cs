using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ElementHittingOtherPredicatedMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly BasePredicate[] prePredicates;
        [JsonProperty] public readonly ElementPredicateds[] elementBatchPredicateds;

        public class ElementPredicateds
        {
            [JsonProperty] public readonly ElementType[] elementTypeArr;
            [JsonProperty] public readonly ConfigAbilityAction[] successActions;
        }
    }
}
