using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetPoseFloat : ConfigAbilityAction
    {
        [JsonProperty] public readonly string floatID;
        [JsonProperty] public readonly object value;
    }
}
