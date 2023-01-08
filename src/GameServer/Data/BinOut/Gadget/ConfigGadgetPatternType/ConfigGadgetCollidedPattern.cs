using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetTriggerActionType;

namespace Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetPatternType
{
    internal class ConfigGadgetCollidedPattern : ConfigGadgetPattern
    {
        [JsonProperty] public readonly ConfigBaseGadgetTriggerAction[] collisionActions;
        [JsonProperty] public readonly string thisColliderName;
        [JsonProperty] public readonly string targetColliderName;
    }
}
