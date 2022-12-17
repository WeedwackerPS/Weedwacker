using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.SelectTargetType
{
    internal class SelectTargetsByLCTrigger : BaseSelectTargetType
    {
        [JsonProperty] public readonly TargetType campTargetType;
        [JsonProperty] public readonly string sortType;
        [JsonProperty] public readonly int topLimit;
    }
}
