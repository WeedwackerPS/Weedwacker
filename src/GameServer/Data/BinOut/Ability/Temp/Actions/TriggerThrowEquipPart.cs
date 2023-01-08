using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TriggerThrowEquipPart : ConfigAbilityAction
    {
        [JsonProperty] public readonly string equipPart;
        [JsonProperty] public readonly ConfigBornType born;
    }
}
