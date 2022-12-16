using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class SendPostionToShaderCutMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly TargetType sendTarget;
        [JsonProperty] public readonly float sendRadius;
        [JsonProperty] public readonly Dictionary<string, float> scale;
    }
}
