using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachActionToModifierMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ConfigAbilityAction[] onAdded;
        [JsonProperty] public readonly ConfigAbilityAction[] onRemoved;
    }
}
