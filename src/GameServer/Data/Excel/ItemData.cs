using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{

    internal abstract class ItemData
    {
        [JsonProperty] public readonly uint id;
        [JsonProperty] public readonly uint rank;
        [JsonProperty] public readonly long nameTextMapHash;
        [JsonProperty] public readonly long descTextMapHash;
        [JsonProperty] public readonly string icon;
        [JsonProperty] public readonly uint rankLevel;
        [JsonProperty] public readonly DestroyRule destroyRule;
        [JsonProperty] public readonly uint[]? destroyReturnMaterial;
        [JsonProperty] public readonly int[]? destroyReturnMaterialCount;
        [JsonProperty] public readonly ItemType itemType;
    }
}
