using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity
{
    internal class ConfigTrigger
    {
        [JsonProperty] public readonly TriggerFlag triggerFlag;
        [JsonProperty] public readonly ConcernType concernType;
        [JsonProperty] public readonly string shape;
        [JsonProperty] public readonly bool checkInfinite;
        [JsonProperty] public readonly bool triggerInfinite;
        [JsonProperty] public readonly bool lifeInfinite;
        [JsonProperty] public readonly float startCheckTime;
        [JsonProperty] public readonly float checkInterval;
        [JsonProperty] public readonly int checkCount;
        [JsonProperty] public readonly float triggerInterval;
        [JsonProperty] public readonly int triggerCount;
        [JsonProperty] public readonly float lifeTime;
        [JsonProperty] public readonly bool overwriteCampType;
        [JsonProperty] public readonly TargetType campType;
        [JsonProperty] public readonly bool checkPoint;
        [JsonProperty] public readonly bool useSurfaceHeight;
        [JsonProperty] public readonly bool useCollider;
        [JsonProperty] public readonly string colliderName;
        [JsonProperty] public readonly bool checkGhost;
        [JsonProperty] public readonly bool colliderCheckOnInit;
    }
}
