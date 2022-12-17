using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AddClimateMeter : ConfigAbilityAction
    {
        [JsonProperty] public readonly ClimateType climateType;
        [JsonProperty] public readonly float value;
    }
}
