using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class SetAnimationPauseByAbilityStateMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly AbilityState[] abilityStates;
    }
}
