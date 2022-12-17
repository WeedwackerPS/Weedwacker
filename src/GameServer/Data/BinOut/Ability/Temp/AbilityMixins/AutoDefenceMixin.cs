using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AutoDefenceMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] stateIDs;
        [JsonProperty] public readonly string defendTriggerID;
        [JsonProperty] public readonly float defendProbability;
        [JsonProperty] public readonly float defendProbabilityDelta;
        [JsonProperty] public readonly string defendTimeInterval;
        [JsonProperty] public readonly int defendCountInterval;
    }
}
