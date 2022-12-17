using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class Repeated : ConfigAbilityAction
    {
        [JsonProperty] public readonly string repeatTimes;
        [JsonProperty] public readonly ConfigAbilityAction[] actions;
    }
}
