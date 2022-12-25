using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReactionType
    {
        None,
        FrozenBroken,
        Explode,
        Stream,
        Burning,
        Melt,
        Freeze,
        Shock,
        Superconductor,
        SwirlFire,
        SwirlWater,
        SwirlElectric,
        SwirlIce,
        CrystallizeWater,
        CrystallizeElectric,
        CrystallizeIce,
        CrystallizeFire,
        Overdose,
        OverdoseElectric,
        OverdoseGrass,
        Overgrow,
        OvergrowMushroomFire,
        OvergrowMushroomElectric
    }
}
