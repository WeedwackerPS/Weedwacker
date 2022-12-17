using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SyncEntityPositionByNormalizedTime : ConfigAbilityAction
    {
        [JsonProperty] public readonly float normalizedTime;
    }
}
