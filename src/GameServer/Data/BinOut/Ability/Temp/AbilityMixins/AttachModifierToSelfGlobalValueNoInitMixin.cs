using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachModifierToSelfGlobalValueNoInitMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string globalValueKey;
        [JsonProperty] public readonly float[] valueSteps;
        [JsonProperty] public readonly string[] modifierNameSteps;
    }
}
