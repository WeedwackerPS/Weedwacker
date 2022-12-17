using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SumTargetWeightToSelfGlobalValue : ConfigAbilityAction
    {
        [JsonProperty] public readonly string key;
        [JsonProperty] public readonly BaseSelectTargetType otherTargets;
    }
}
