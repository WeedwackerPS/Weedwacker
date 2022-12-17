using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class VelocityForceMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] excludeForces;
    }
}
