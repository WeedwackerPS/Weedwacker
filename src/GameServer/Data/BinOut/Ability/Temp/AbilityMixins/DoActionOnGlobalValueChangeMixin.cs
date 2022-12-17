using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoActionOnGlobalValueChangeMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string globalValueKey;
        [JsonProperty] public readonly ConfigAbilityAction[] actions;
    }
}
