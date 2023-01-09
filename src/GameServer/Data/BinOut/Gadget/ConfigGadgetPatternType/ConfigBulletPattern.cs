using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetTriggerActionType;

namespace Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetPatternType
{
    internal class ConfigBulletPattern : ConfigGadgetPattern
    {
        [JsonProperty] public readonly ConfigBaseGadgetTriggerAction[] triggerActions;
        [JsonProperty] public readonly ConfigBaseGadgetTriggerAction[] triggerLifeOverActions;
        [JsonProperty] public readonly bool killByOther;
        [JsonProperty] public readonly float dieDelayTime;
        [JsonProperty] public readonly bool checkGrass;
        [JsonProperty] public readonly bool checkWater;
        [JsonProperty] public readonly float checkInterval;
        [JsonProperty] public readonly bool needCreateGw;
        [JsonProperty] public readonly bool fireAiSoundEvent;
        [JsonProperty] public readonly float maxAutoKillDist;
        [JsonProperty] public readonly float enableCollisionDelay;
    }
}
