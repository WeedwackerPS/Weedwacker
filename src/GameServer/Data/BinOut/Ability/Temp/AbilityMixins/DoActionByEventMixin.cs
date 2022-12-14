using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoActionByEventMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly AvatarEventType onEvent;
        [JsonProperty] public readonly string type;
        [JsonProperty] public readonly BasePredicate[] predicates;
        [JsonProperty] public readonly ConfigAbilityAction[] actions;
    }
}