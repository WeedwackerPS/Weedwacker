using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AvatarEventType
    {
        None,
        HP,
        HPUp,
        HPDown,
        ChestOpen,
        PickItem,
        Energy
    }
}
