using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("ReliquaryMainPropExcelConfigData.json")]
    internal class ReliquaryMainPropData
    {
        [JsonProperty] public readonly uint id;
        [JsonProperty] public readonly uint propDepotId;
        [JsonProperty] public readonly FightProperty propType;
        [JsonProperty] public readonly int weight;
    }
}
