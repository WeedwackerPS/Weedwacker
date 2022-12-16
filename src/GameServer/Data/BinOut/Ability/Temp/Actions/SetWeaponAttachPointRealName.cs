using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetWeaponAttachPointRealName : ConfigAbilityAction
    {
        [JsonProperty] public readonly string partName;
        [JsonProperty] public readonly string realName;
    }
}
