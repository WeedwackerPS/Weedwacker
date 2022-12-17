using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class PaimonAction : ConfigAbilityAction
    {
        [JsonProperty] public readonly string from;
        [JsonProperty] public readonly string actionName;
    }
}
