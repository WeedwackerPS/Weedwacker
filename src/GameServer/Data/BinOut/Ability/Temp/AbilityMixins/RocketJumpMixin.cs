using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class RocketJumpMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string type;
        [JsonProperty] public readonly bool uiEffect;
        [JsonProperty] public readonly Extension extention;

        public class Extension
        {
            [JsonProperty] public readonly float xzMultiplier;
            [JsonProperty] public readonly float yMultiplier;
        }
    }
}
