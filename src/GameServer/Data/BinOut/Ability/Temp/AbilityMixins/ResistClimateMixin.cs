using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ResistClimateMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string type;
        [JsonProperty] public readonly ClimateType[] climateTypes;
        [JsonProperty] public readonly string source;
        [JsonProperty] public readonly string trend;
        [JsonProperty] public readonly object ratio;
    }
}
