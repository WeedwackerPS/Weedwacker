using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AttackByEnergy : ConfigAbilityAction
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly float energy;
        [JsonProperty] public readonly float overDamageRatio;
        [JsonProperty] public readonly float overDamageMaxHPRatio;
    }
}
