using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AttackPatterns
{
    internal class ConfigAttackSphere : BaseAttackPattern
    {
        [JsonProperty] public readonly object radius;
        [JsonProperty] public readonly bool ignoreMassive;
    }
}
