using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class OverrideAvatarMoveSpeedRatioMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly double maxValue;
    }
}
