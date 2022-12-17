using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class CaptureAnimal : ConfigAbilityAction
    {
        [JsonProperty] public readonly int materialId;
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
