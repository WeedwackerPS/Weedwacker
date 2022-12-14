using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByEquipAffixReady : BasePredicate
    {
        [JsonProperty] public readonly int equipAffixDataID;
        [JsonProperty] public readonly TargetType target;
    }
}
