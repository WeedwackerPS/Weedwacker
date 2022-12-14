using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DummyMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ConfigAbilityAction[] actionList;
    }
}
