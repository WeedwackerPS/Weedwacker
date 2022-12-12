using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ApplyModifierWithSharedDurabilityMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string modifierName;
    }
}
