using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("MonsterDescribeExcelConfigData.json")]
    internal class MonsterDescribeData
    {
        [JsonProperty] public readonly uint id;
        [JsonProperty] public readonly ulong nameTextMapHash;
        [JsonProperty] public readonly uint titleId;
        [JsonProperty] public readonly uint specialNameLabId;
        [JsonProperty] public readonly string icon;
    }
}
