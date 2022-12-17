using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VelocityForceType
    {
        RushMoveType,
        InertiaType,
        RetreatAirType,
        WindZoneType,
        LightCoreTypeNormal,
        LightCoreTypeAccelerate,
    }
}
