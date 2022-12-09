using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OpenStateCondType
    {
        NONE,
        OPEN_STATE_COND_PARENT_QUEST,
        OPEN_STATE_COND_QUEST,
        OPEN_STATE_COND_PLAYER_LEVEL,
        OPEN_STATE_OFFERING_LEVEL,
        OPEN_STATE_CITY_REPUTATION_LEVEL,
        OPEN_STATE_COND_GCG_LEVEL,
    }
}
