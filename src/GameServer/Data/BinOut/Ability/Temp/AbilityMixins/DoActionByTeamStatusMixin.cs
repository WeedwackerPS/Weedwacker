using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoActionByTeamStatusMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ConfigAbilityAction[] actions;
    }
}
