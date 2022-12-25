using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.SelectTargetType;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TriggerGatherCollect : ConfigAbilityAction
    {
        [JsonProperty] public readonly SelectTargetsByShape selectTargets;
        [JsonProperty] public readonly int maxCount;
    }
}
