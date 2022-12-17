using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TriggerDropEquipParts : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool dropAll;
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
