using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AddChargeBarValue : ConfigAbilityAction
    {
        [JsonProperty] public readonly object value;
    }
}
