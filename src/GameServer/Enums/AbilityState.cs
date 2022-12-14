using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AbilityState
    {
        None,
        ElementBurning,
        ElementFire,
        ElementFreeze,
        ElementFrozen,
        ElementIce,
        ElementPetrifaction,
        ElementWet,
        Invincible,
        Limbo,
        LockHP,
        MuteTaunt,
    }
}
