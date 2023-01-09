using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("RewardExcelConfigData.json")]
    public class RewardData
    {
        [JsonProperty] public readonly uint rewardId;
        [JsonProperty] public readonly ItemParamData[] rewardItemList;
    }
}
