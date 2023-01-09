using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetTriggerActionType
{
    internal class ConfigGadgetDamageByAttackValue : ConfigBaseGadgetTriggerAction
    {
        [JsonProperty] public readonly ConfigBornType[] born;
        [JsonProperty] public readonly ConfigAttackInfo attackInfo;
    }
}
