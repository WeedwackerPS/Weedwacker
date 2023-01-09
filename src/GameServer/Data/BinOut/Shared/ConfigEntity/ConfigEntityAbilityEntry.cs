using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity
{
    internal class ConfigEntityAbilityEntry
    {
        [JsonProperty] public readonly string abilityId;
        [JsonProperty] public readonly string abilityName;
        [JsonProperty] public readonly string abilityOverride;
    }
}
