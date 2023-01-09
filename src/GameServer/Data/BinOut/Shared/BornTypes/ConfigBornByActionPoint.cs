using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes
{
    internal class ConfigBornByActionPoint : ConfigBornType
    {
        [JsonProperty] public readonly PointType actionPointType;
        [JsonProperty] public readonly BaseSelectTargetType selectType;
        [JsonProperty] public readonly bool onGround;
    }
}
