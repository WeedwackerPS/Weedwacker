using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class FireGainCrystalSeedEvent : ConfigAbilityAction
    {
        [JsonProperty] public readonly ElementType elementType;
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
