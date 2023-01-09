using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("MaterialExcelConfigData.json")]
    internal class MaterialData : ItemData
    {
        [JsonProperty] public readonly ulong interactionTitleTextMapHash;
        [JsonProperty] public readonly MaterialType materialType;
        [JsonProperty] public readonly uint stackLimit;
        [JsonProperty] public readonly uint maxUseCount;
        [JsonProperty] public readonly bool useOnGain;
        [JsonProperty] public readonly bool noFirstGetHint;
        [JsonProperty] public readonly ItemUseTarget useTarget;
        [JsonProperty] public readonly List<ItemUseData>? itemUse;
        [JsonProperty] public readonly FoodQuality foodQuality;
        [JsonProperty] public readonly ulong effectDescTextMapHash;
        [JsonProperty] public readonly ulong specialDescTextMapHash;
        [JsonProperty] public readonly ulong typeDescTextMapHash;
        [JsonProperty] public readonly string effectIcon;
        [JsonProperty] public readonly string effectName;
        [JsonProperty] public readonly string[] picPath;
        [JsonProperty] public readonly bool isSplitDrop;
        [JsonProperty] public readonly bool closeBagAfterUsed;
        [JsonProperty] public readonly int[]? satiationParams;
        [JsonProperty] public readonly bool isForceGetHint;
        [JsonProperty] public readonly uint gadgetId;
    }
}
