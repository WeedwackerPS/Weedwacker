using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.AbilityGroup
{
    internal class AbilityGroupData
    {
        [JsonProperty] public readonly AbilityGroupSourceType abilityGroupSourceType;
        [JsonProperty] public readonly AbilityGroupTargetType abilityGroupTargetType;
        [JsonProperty] public readonly ConfigEntityAbilityEntry[] targetAbilities;
    }
}
