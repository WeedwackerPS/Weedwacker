using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class OverrideMonsterMoveSpeedRatioMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly float minValue;
        [JsonProperty] public readonly float maxValue;
    }
}
