using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AddGlobalValueToTarget : ConfigAbilityAction
    {
        [JsonProperty] public readonly TargetType srcTarget;
        [JsonProperty] public readonly TargetType dstTarget;
        [JsonProperty] public readonly string srcKey;
        [JsonProperty] public readonly string dstKey;
    }
}
