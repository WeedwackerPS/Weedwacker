using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TriggerSetCastShadow : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool castShadow;
        [JsonProperty] public readonly TargetType target;
    }
}
