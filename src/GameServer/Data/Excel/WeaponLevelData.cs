using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("WeaponLevelExcelConfigData.json")]
    internal class WeaponLevelData : ItemData
    {
        [JsonProperty] public readonly uint level;
        [JsonProperty] public readonly uint[] requiredExps;
    }
}
