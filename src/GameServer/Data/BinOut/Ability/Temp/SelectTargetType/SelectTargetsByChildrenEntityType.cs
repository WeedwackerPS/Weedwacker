using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.SelectTargetType
{
    internal class SelectTargetsByChildrenEntityType : BaseSelectTargetType
    {
        [JsonProperty] public readonly EntityType entityType;
        [JsonProperty] public readonly string sortType;
    }
}
