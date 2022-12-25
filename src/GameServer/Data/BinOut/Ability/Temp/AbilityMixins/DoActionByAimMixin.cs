using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoActionByAimMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly EntityType[] entityTypes;
        [JsonProperty] public readonly float cd;
        [JsonProperty] public readonly string colliderNodeName;
        [JsonProperty] public readonly ConfigAbilityAction[] actionQueue;
        [JsonProperty] public readonly BasePredicate[] predicates;
        [JsonProperty] public readonly ConfigAbilityAction[] onRemoveActionQueue;
    }
}
