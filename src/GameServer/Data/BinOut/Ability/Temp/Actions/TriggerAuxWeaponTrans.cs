using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TriggerAuxWeaponTrans : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool setEnable;
        [JsonProperty] public readonly string equipPart;
    }
}
