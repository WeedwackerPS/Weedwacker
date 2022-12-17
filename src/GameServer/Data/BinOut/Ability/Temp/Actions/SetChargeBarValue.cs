using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetChargeBarValue : ConfigAbilityAction
    {
        [JsonProperty] public readonly float value;
    }
}
