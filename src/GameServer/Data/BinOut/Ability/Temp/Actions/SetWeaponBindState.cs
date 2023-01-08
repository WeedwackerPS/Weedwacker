using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetWeaponBindState : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool place;
        [JsonProperty] public readonly string equipPartName;
        [JsonProperty] public readonly ConfigBornType born;
    }
}
