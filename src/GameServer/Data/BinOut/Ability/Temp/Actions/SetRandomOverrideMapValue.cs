using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetRandomOverrideMapValue : ConfigAbilityAction
    {
        [JsonProperty] public readonly float valueRangeMax;
        [JsonProperty] public readonly string overrideMapKey;
    }
}
