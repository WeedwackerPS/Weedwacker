using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("WeatherExcelConfigData.json")]
    internal class WeatherData
    {
        [JsonProperty] public readonly uint areaId;
        [JsonProperty] public readonly uint weatherAreaId;
        [JsonProperty] public readonly string maxHeightStr;
        [JsonProperty] public readonly uint gadgetId;
        [JsonProperty] public readonly bool isDefaultValid;
        [JsonProperty] public readonly int priority;
        [JsonProperty] public readonly string profileName;
        [JsonProperty] public readonly ClimateType defaultClimate;
        [JsonProperty] public readonly bool isUseDefault;
        [JsonProperty] public readonly uint sceneId;
    }
}
