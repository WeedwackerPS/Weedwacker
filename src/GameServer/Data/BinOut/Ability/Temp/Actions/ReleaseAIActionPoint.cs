using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ReleaseAIActionPoint : ConfigAbilityAction
    {
        [JsonProperty] public readonly PointType pointType;
    }
}
