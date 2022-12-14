using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ActTimeSlow : ConfigAbilityAction
    {
        [JsonProperty] public readonly TimeSlow timeSlow;

        public class TimeSlow
        {
            [JsonProperty] public readonly float duration;
            [JsonProperty] public readonly float slowRatio;
        }
    }
}
