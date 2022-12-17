using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TriggerThrowEquipPart : ConfigAbilityAction
    {
        [JsonProperty] public readonly string equipPart;
        [JsonProperty] public readonly BaseBornType born;
    }
}
