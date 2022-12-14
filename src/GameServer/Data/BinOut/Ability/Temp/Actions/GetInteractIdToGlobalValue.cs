using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class GetInteractIdToGlobalValue : ConfigAbilityAction
    {
        [JsonProperty] public readonly string key;
    }
}
