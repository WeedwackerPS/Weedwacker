using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class Randomed : ConfigAbilityAction
    {
        [JsonProperty] public readonly object chance;
        [JsonProperty] public readonly ConfigAbilityAction[] successActions;
        [JsonProperty] public readonly ConfigAbilityAction[] failActions;
    }
}
