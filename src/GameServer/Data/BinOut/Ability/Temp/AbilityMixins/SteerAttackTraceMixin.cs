using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class SteerAttackTraceMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] steerStateIDs;
        [JsonProperty] public readonly float startNormalizedTime;
        [JsonProperty] public readonly float endNormalizedTime;
        [JsonProperty] public readonly float angularSpeed;
    }
}
