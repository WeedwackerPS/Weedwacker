using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class OverrideHitImpulseMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly Dictionary<string, overrideHitImpulse> overrideHitImpulseMap;

        internal class overrideHitImpulse
        {
            [JsonProperty] public readonly string hitLevel;
            [JsonProperty] public readonly float hitImpulseX;
            [JsonProperty] public readonly float hitImpulseY;
        }
    }
}
