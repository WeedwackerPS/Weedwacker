
using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("WeaponLevelExcelConfigData.json")]
    internal class WeaponLevelData : ItemData
    {
        [JsonProperty]
        public readonly int level;
        [JsonProperty]
        public readonly int[] requiredExps;
    }
}
