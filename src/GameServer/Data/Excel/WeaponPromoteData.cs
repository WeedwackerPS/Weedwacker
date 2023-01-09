using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("WeaponPromoteExcelConfigData.json")]
    internal class WeaponPromoteData
    {
        [JsonProperty] public readonly uint weaponPromoteId;
        [JsonProperty] public readonly uint promoteLevel;
        [JsonProperty] public readonly ItemParamData[] costItems;
        [JsonProperty] public readonly int coinCost;
        [JsonProperty] public readonly FightPropData[] addProps;
        [JsonProperty] public readonly uint unlockMaxLevel;
        [JsonProperty] public readonly uint requiredPlayerLevel;
    }
}
