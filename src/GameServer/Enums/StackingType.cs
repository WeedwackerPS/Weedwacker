using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StackingType
    {
        None,
        Unique,
        Multiple,
        MultipleAllRefresh,
        MultipleRefresh,
        MultipleRefreshNoRemove,
        Overlap,
        Refresh,
        RefreshUniqueDurability,
        RefreshAndAddDurability,
    }
}
