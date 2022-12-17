using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class RemoveModifierByAbilityStateResistanceID : ConfigAbilityAction
    {
        [JsonProperty] public readonly int resistanceListID;
    }
}
