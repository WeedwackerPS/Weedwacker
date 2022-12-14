using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoReviveMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ConfigAbilityAction[] onReviveActions;
    }
}
