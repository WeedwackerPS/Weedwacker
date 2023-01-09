using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared
{
    internal abstract class BaseAttackPattern
    {
        [JsonProperty] public readonly TriggerType triggerType;
        [JsonProperty] public readonly ConfigBornType born;
    }
}
