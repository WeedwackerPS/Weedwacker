using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachModifierToSelfGlobalValueMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string globalValueKey;
        [JsonProperty] public readonly float defaultGlobalValueOnCreate;
        [JsonProperty] public readonly object[] valueSteps;
        [JsonProperty] public readonly string[] modifierNameSteps;
    }
}
