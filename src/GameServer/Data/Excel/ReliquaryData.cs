using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("ReliquaryExcelConfigData.json")]
    internal class ReliquaryData : ItemData
    {
        [JsonProperty] public readonly EquipType equipType;
        [JsonProperty] public readonly string showPic;
        [JsonProperty] public readonly uint mainPropDepotId;
        [JsonProperty] public readonly uint appendPropDepotId;
        [JsonProperty] public readonly int[]? addPropLevels;
        [JsonProperty] public readonly uint appendPropNum;
        [JsonProperty] public readonly uint baseConvExp;
        [JsonProperty] public readonly uint maxLevel;
        [JsonProperty] public readonly int weight;
        [JsonProperty] public readonly uint setId;
        [JsonProperty] public readonly uint gadgetId;
    }
}
