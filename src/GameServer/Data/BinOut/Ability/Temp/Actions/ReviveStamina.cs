using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ReviveStamina : ConfigAbilityAction
    {
        [JsonProperty] public readonly object value;
    }
}
