using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TriggerCreateGadgetToEquipPart : ConfigAbilityAction
    {
        [JsonProperty] public readonly int gadgetID;
        [JsonProperty] public readonly string equipPart;
    }
}
