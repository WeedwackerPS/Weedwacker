using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TryFindBlinkPoint : ConfigAbilityAction
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly float forwardAngle;
        [JsonProperty] public readonly float minRange;
        [JsonProperty] public readonly float maxRange;
    }
}
