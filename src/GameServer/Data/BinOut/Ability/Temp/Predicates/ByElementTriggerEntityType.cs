using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByElementTriggerEntityType : BasePredicate
    {
        [JsonProperty] public readonly bool forcebyOriginOwner;
        [JsonProperty] public readonly EntityType[] entityTypes;
    }
}
