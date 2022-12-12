using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AddClimateMeter : BaseAction
    {
        [JsonProperty] public readonly ClimateType climateType;
        [JsonProperty] public readonly float value;
    }
}
