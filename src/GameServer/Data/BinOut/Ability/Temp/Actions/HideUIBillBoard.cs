using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class HideUIBillBoard : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool hide;
    }
}
