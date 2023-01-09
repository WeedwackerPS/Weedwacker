using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Common
{
    internal class PropGrowCurve
    {
        [JsonProperty] public readonly FightProperty type;
        [JsonProperty] public readonly GrowCurveType growCurve;
    }
}
