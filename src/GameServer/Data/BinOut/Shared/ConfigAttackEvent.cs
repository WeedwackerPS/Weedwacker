using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data.BinOut.Shared
{
    internal class ConfigAttackEvent
    {
        [JsonProperty] public readonly BaseAttackPattern attackPattern;
        [JsonProperty] public readonly AttackInfo attackInfo;
    }
}
