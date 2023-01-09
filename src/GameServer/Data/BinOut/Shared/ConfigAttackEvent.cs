using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared
{
    internal class ConfigAttackEvent
    {
        [JsonProperty] public readonly BaseAttackPattern attackPattern;
        [JsonProperty] public readonly ConfigAttackInfo attackInfo;
    }
}
