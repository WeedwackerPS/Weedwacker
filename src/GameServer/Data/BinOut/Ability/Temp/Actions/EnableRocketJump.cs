using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnableRocketJump : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool canBeHandledOnRecover;
        [JsonProperty] public readonly bool enable;
        [JsonProperty] public readonly Extension extention;

        public class Extension
        {
            [JsonProperty] public readonly float xzMultiplier;
            [JsonProperty] public readonly float yMultiplier;
        }
    }
}
