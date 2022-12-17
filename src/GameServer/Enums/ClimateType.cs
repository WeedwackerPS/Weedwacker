using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClimateType
    {
        CLIMATE_DESERT,
        CLIMATE_SUNNY,
        CLIMATE_CLOUDY,
        CLIMATE_MIST,
        CLIMATE_RAIN,
        CLIMATE_THUNDERSTORM,
        Cold,
        ColdMonster, // wtf
        HotMonster, // oh
        SeaMist,
        TatariRegion,
        TsurumiRegionalMist,
        HeroCourse, // is this really climate type?
    }
}
