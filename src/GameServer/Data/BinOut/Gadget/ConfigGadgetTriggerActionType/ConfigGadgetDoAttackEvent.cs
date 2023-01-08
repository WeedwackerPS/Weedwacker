using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetTriggerActionType
{
    internal class ConfigGadgetDoAttackEvent : ConfigBaseGadgetTriggerAction
    {
        [JsonProperty] public readonly string attackEvent;
    }
}
