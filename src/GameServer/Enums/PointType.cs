using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PointType
    {
        NONE,
        PORTAL,
        TOWER,
        NORMAL,
        CatFeedPoint,
        DogFeedPoint,
        AureaePoint,
        SleepPoint,
        OceanidMovePoint,
        SitPoint,
        PreachPoint,
        ThreatPoint,
        MakingPoint,
        DancingPoint,
        TrainingPoint,
        SurroundPoint,
        BuildingPoint,
        SearchPoint,
    }
}
