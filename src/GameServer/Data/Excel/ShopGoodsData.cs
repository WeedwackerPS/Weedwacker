using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("ShopGoodsExcelConfigData.json")]
    internal class ShopGoodsData
    {
        [JsonProperty] public readonly uint goodsId;
        [JsonProperty] public readonly ulong subTagNameTextMapHash;
        [JsonProperty] public readonly uint shopType;
        [JsonProperty] public readonly uint itemId;
        [JsonProperty] public readonly uint itemCount;
        [JsonProperty] public readonly int costScoin;
        [JsonProperty] public readonly int costHcoin;
        [JsonProperty] public readonly int costMcoin;
        [JsonProperty] public readonly ItemParamData[] costItems;
        [JsonProperty] public readonly uint minPlayerLevel;
        [JsonProperty] public readonly uint maxPlayerLevel;
        [JsonProperty] public readonly uint buyLimit;
        [JsonProperty] public readonly uint subTabId;
        [JsonProperty] public readonly ShopRefreshType refreshType;
        [JsonProperty] public readonly int refreshParam;
        [JsonProperty] public readonly string? beginTime;
        [JsonProperty] public readonly string? endTime;
        [JsonProperty] public readonly PreConditionType precondition;
        [JsonProperty] public readonly int preconditionParam;
        [JsonProperty] public readonly string[]? preconditionParamList;
        [JsonProperty] public readonly bool preconditionHidden;
        [JsonProperty] public readonly uint minShowLevel;
        [JsonProperty] public readonly uint sortLevel;
        [JsonProperty] public readonly uint secondarySheetId;
        //[JsonProperty] public readonly ??? platformTypeList;
    }
}
