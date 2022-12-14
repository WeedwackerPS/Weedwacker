using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ReviveElemEnergyMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string type;
        [JsonProperty] public readonly object period;
        [JsonProperty] public readonly object baseEnergy;
        [JsonProperty] public readonly object ratio;
    }
}
