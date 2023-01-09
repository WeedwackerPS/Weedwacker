using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("ReliquarySetExcelConfigData.json")]
    internal class ReliquarySetData
    {
        [JsonProperty] public readonly uint setId;
        [JsonProperty] public readonly string setIcon;
        [JsonProperty] public readonly int[] setNeedNum;

        [JsonProperty] public readonly uint EquipAffixId;
        [JsonProperty] public readonly int[] containsList;
        [JsonProperty] public readonly int DisableFilter;
        // Missing 2 properties
        [JsonProperty] public readonly ulong[] textList;
    }
}
