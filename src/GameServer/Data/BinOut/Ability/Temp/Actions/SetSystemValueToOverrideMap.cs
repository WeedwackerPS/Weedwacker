using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetSystemValueToOverrideMap : ConfigAbilityAction
    {
        [JsonProperty] public readonly string key;
        [JsonProperty] public readonly string type;
    }
}
