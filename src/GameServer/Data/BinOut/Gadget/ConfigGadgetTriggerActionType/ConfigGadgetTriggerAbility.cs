using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetTriggerActionType
{
    internal class ConfigGadgetTriggerAbility : ConfigBaseGadgetTriggerAction
    {
        [JsonProperty] public readonly string abilityName;
    }
}
