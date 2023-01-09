using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("ReliquaryAffixExcelConfigData.json")]
    internal class ReliquaryAffixData
    {
        [JsonProperty] public readonly uint id;
        [JsonProperty] public readonly uint depotId;
        [JsonProperty] public readonly uint groupId;
        [JsonProperty] public readonly FightProperty propType;
        [JsonProperty] public readonly float propValue;
        [JsonProperty] public readonly int weight;
        [JsonProperty] public readonly int upgradeWeight;
    }
}
