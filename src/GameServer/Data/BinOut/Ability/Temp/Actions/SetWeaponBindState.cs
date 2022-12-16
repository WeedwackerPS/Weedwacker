using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetWeaponBindState : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool place;
        [JsonProperty] public readonly string equipPartName;
        [JsonProperty] public readonly BaseBornType born;
    }
}
