using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AttachElementTypeResistance : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool doOffStage;
        [JsonProperty] public readonly ElementType elementType;
        [JsonProperty] public readonly object durationRatio;
    }
}
