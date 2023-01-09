using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("GatherExcelConfigData.json")]
    internal class GatherData
    {
        [JsonProperty] public readonly uint id;
        [JsonProperty] public readonly uint areaId;
        [JsonProperty] public readonly int pointType;
        [JsonProperty] public readonly uint gadgetId;
        [JsonProperty] public readonly uint itemId;
        //[JsonProperty] public readonly ???[] extraItemIdVec;
        [JsonProperty] public readonly string pointLocation;
        [JsonProperty] public readonly int cd;
        [JsonProperty] public readonly int priority;
        [JsonProperty] public readonly uint refreshId;
        [JsonProperty] public readonly BlockLimit[] blockLimits;
        [JsonProperty] public readonly bool initDisableInteract;
        [JsonProperty] public readonly bool isForbidGuest;
        [JsonProperty] public readonly SaveType saveType;

        public class BlockLimit
        {
            [JsonProperty] public readonly uint blockId;
            [JsonProperty] public readonly int count;
        }
    }
}
