using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetSurroundAnchor : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool setPoint;
        [JsonProperty] public readonly PointType actionPointType;
        [JsonProperty] public readonly bool canBeHandledOnRecover;
    }
}
