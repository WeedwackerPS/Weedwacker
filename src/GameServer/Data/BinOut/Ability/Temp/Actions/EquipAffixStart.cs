using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EquipAffixStart : ConfigAbilityAction
    {
        [JsonProperty] public readonly object CD;
        [JsonProperty] public readonly int equipAffixDataID;
    }
}
