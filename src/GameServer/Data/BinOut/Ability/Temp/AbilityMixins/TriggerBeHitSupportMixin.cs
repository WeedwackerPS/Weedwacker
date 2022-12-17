using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class TriggerBeHitSupportMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly float duration;
        [JsonProperty] public readonly string hitLevel;
    }
}
