using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class WidgetMpSupportMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ConfigAbilityAction[] succActions;
    }
}
