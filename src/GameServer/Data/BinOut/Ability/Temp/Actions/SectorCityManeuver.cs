using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SectorCityManeuver : ConfigAbilityAction
    {
        [JsonProperty] public readonly string attachPointName;
        [JsonProperty] public readonly bool start;
    }
}
