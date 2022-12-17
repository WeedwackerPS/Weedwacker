using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetGlobalValue : ConfigAbilityAction
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly bool doOffStage;
        [JsonProperty] public readonly object value;
        [JsonProperty] public readonly string key;
        [JsonProperty] public readonly object maxValue;
        [JsonProperty] public readonly float minValue;
    }
}
