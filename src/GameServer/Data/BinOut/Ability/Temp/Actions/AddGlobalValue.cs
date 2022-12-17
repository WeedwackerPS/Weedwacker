using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AddGlobalValue : ConfigAbilityAction
    {
        [JsonProperty] public readonly object value;
        [JsonProperty] public readonly string key;
        [JsonProperty] public readonly bool useLimitRange;
        [JsonProperty] public readonly object maxValue;
        [JsonProperty] public readonly object minValue;
    }
}
