using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoActionByEntityKillMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly BasePredicate[] predicates;
        [JsonProperty] public readonly ConfigAbilityAction[] actionQueue;
    }
}
