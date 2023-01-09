using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("EnvAnimalGatherExcelConfigData.json")]
    internal class EnvAnimalGatherData
    {
        [JsonProperty] public readonly uint animalId;
        [JsonProperty] public readonly int areaId;
        [JsonProperty] public readonly EntityType entityType;
        [JsonProperty] public readonly GatherItem[] gatherItemId;
        [JsonProperty] public readonly int escapeRadius;
        [JsonProperty] public readonly int escapeTime;
        [JsonProperty] public readonly int aliveTime;
        [JsonProperty] public readonly string excludeWeathers;
    }

    public class GatherItem
    {
        [JsonProperty] public readonly uint id;
        [JsonProperty] public readonly int count;
    }
}
