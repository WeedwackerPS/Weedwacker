using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class OnParentAbilityStartMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ConfigAbilityAction[] actionList;
    }
}
