using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetCameraEntityDampRatio : ConfigAbilityAction
    {
        [JsonProperty] public readonly float dampRatio;
        [JsonProperty] public readonly ByTrampolineType[] predicates;
    }
}
