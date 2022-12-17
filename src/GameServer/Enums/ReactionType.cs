using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReactionType
    {
        None,
        Burning,
        CrystallizeElectric,
        CrystallizeFire,
        CrystallizeIce,
        CrystallizeWater,
        Explode,
        Freeze,
        FrozenBroken,
        Melt,
        Shock,
        Stream,
        Superconductor,
        SwirlElectric,
        SwirlFire,
        SwirlIce,
        SwirlWater,
        Overgrow,
        Overdose,
    }
}
