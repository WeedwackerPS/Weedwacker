using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachToPlayStageMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int stage;
        [JsonProperty] public readonly ConfigAbilityAction[] actions;
    }
}
