using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes
{
    internal class ConfigBornByTargetLinearPoint : ConfigBornType
    {
        [JsonProperty] public readonly float linearOffset;
        [JsonProperty] public readonly bool linearXZ;
        [JsonProperty] public readonly bool baseOnTarget;
    }
}
