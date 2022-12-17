using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AttachAbilityStateResistance : ConfigAbilityAction
    {
        [JsonProperty] public readonly int resistanceListID;
    }
}
