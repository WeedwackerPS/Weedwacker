using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class GetTeamTotalMaxEnergyToOverridemap : ConfigAbilityAction
    {
        [JsonProperty] public readonly TargetType teamType;
        [JsonProperty] public readonly bool doOffStage;
        [JsonProperty] public readonly string overrideMapKey;
    }
}
