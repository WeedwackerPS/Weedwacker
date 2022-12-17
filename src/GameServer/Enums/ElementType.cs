using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ElementType
    {
        None,
        AntiFire,
        Fire = 2,
        Water = 3,
        Wind = 4,
        Ice = 5,
        Rock = 6,
        Electric = 7,
        Grass = 8,
        Frozen,
        Default = 255,
        VehicleMuteIce, //wtf
    }
}
