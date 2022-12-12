using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachToGadgetStateMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int gadgetState;
        [JsonProperty] public readonly string modifierName;
    }
}
