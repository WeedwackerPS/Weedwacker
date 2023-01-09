using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarTalentExcelConfigData.json")]
    public class AvatarTalentData
    {
        [JsonProperty] public readonly uint talentId;
        [JsonProperty] public readonly uint prevTalent;
        [JsonProperty] public readonly ulong nameTextMapHash;
        [JsonProperty] public readonly string icon;
        [JsonProperty] public readonly uint mainCostItemId;
        [JsonProperty] public readonly int mainCostItemCount;
        [JsonProperty] public readonly string openConfig;
        [JsonProperty] public readonly FightPropData[] addProps;
        [JsonProperty] public readonly double[] paramList;
    }
}
