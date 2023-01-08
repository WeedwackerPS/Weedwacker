using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared
{
    internal class ConfigCollision
    {
        [JsonProperty] public readonly ConfigCcd ccd;
        [JsonProperty] public readonly ColliderTriggerType triggerType;
        [JsonProperty] public readonly float triggerCD;
        [JsonProperty] public readonly TargetType targetType;
        [JsonProperty] public readonly bool ignoreScene;
        [JsonProperty] public readonly bool ignoreWater;
        [JsonProperty] public readonly bool bornWithTriggerEnabled;
        [JsonProperty] public readonly float delayEnableCollision;

        public class ConfigCcd
        {
            [JsonProperty] public readonly CcdType type;
            [JsonProperty] public readonly float detectCd;
        }
    }
}
