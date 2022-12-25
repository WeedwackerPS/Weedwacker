using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachToStateGroupNormalizedTimeMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] stateGroup;
        [JsonProperty] public readonly string modifierName;
    }
}
