using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class VelocityDetectMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly float minSpeed;
        [JsonProperty] public readonly float maxSpeed;
        [JsonProperty] public readonly ConfigAbilityAction[] onNegedge;
    }
}
