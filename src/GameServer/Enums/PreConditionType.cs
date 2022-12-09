using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PreConditionType
    {
        SHOP_PRECONDITION_QUEST_FINISH_ANY,
        SHOP_PRECONDITION_SPECIFY,
        SHOP_PRECONDITION_REST,
        SHOP_PRECONDITION_DONE_TEASURE_SEELIE_REGION,
        SHOP_PRECONDITION_SHEET_FLEUR_FAIR_WATCHER_FINISH,
        SHOP_PRECONDITION_SHEET_REST,
        SHOP_PRECONDITION_HOME_LEVEL,
        SHOP_PRECONDITION_QUEST_FINISH,
        SHOP_PRECONDITION_GCG_LEVEL,
    }
}
