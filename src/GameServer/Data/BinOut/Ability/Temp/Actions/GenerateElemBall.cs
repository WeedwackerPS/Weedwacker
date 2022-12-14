using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class GenerateElemBall : ConfigAbilityAction
    {
        [JsonProperty] public readonly int configID;
        [JsonProperty] public readonly BaseBornType born;
        [JsonProperty] public readonly object ratio;
        [JsonProperty] public readonly float baseEnergy;
    }
}
