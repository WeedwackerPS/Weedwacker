using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class DeductStamina : ConfigAbilityAction
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly float value;
    }
}
