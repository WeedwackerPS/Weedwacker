using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    internal class DisplayItemData : ItemData
    {
        [JsonProperty] public readonly DisplayType displayType;
        [JsonProperty] public readonly int param;

    }
}
