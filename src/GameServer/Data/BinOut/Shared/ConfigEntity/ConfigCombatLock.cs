using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity
{
    internal class ConfigCombatLock
    {
        [JsonProperty] public readonly string lockShape;
        [JsonProperty] public readonly bool denyLockOn;
        [JsonProperty] public readonly float lockWeightYaxisParam;
        [JsonProperty] public readonly float lockWeightYaxisThreshold;
        [JsonProperty] public readonly string lockType;
        [JsonProperty] public readonly float overrideRange;
        [JsonProperty] public readonly float overrideNormalPri;
        [JsonProperty] public readonly float overrideCombatPri;
    }
}
