using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CompareType
    {
        None,
        Lesser,
        LesserOrEqual,
        MoreThan,
        Greater,
        XYZ,
        XZ,
        Y,
    }
}
