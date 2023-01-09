
using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarPromoteExcelConfigData.json")]
    public class AvatarPromoteData
    {
        [JsonProperty] public readonly uint avatarPromoteId;
        [JsonProperty] public readonly uint promoteLevel;
        [JsonProperty] public readonly string promoteAudio;
        [JsonProperty] public readonly uint scoinCost;
        [JsonProperty] public readonly ItemParamData[] costItems;
        [JsonProperty] public readonly uint unlockMaxLevel;
        [JsonProperty] public readonly FightPropData[] addProps;
        [JsonProperty] public readonly uint requiredPlayerLevel;
    }
}
