using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class RegisterAIActionPoint : ConfigAbilityAction
    {
        [JsonProperty] public readonly PointType pointType;
    }
}
