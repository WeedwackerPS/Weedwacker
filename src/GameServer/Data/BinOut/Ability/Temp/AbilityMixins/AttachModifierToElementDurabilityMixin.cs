using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachModifierToElementDurabilityMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly object[] valueSteps;
        [JsonProperty] public readonly string[] modifierNameSteps;
    }
}
