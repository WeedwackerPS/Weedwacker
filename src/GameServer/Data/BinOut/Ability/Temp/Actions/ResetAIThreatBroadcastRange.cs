using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ResetAIThreatBroadcastRange : ConfigAbilityAction
    {
        [JsonProperty] public readonly float range;
        [JsonProperty] public readonly bool canBeHandledOnRecover;
    }
}
