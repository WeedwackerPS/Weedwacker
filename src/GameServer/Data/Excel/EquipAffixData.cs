using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("EquipAffixExcelConfigData.json")]
    public class EquipAffixData
    {
        [JsonProperty] public readonly uint affixId;
        [JsonProperty] public readonly uint id;
        [JsonProperty] public readonly uint level;
        [JsonProperty] public readonly ulong nameTextMapHash;
        [JsonProperty] public readonly string openConfig;
        [JsonProperty] public readonly FightPropData[] addProps;
        [JsonProperty] public readonly float[] paramList;
    }
}
