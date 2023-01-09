using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VelocityForceType
    {
        RetreatType,
        RetreatAirType,
        RushMoveType,
        WindZoneType,
        AirflowType,
        RiseType,
        SpeedupType,
        AirflowAccType,
        InertiaType,
        FixedRushMoveType,
        LightCoreTypeNormal,
        LightCoreTypeAccelerate,
        GorouZoneType,
        UgcDirectedForceType
    }
}
