using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetGlobalPos : ConfigAbilityAction
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly string key;
        [JsonProperty] public readonly BaseBornType born;
        [JsonProperty] public readonly bool setTarget;
    }
}
