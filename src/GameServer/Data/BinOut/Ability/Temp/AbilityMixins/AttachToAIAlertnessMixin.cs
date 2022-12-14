using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachToAIAlertnessMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int[] alertness;
        [JsonProperty] public readonly string modifierName;
    }
}
