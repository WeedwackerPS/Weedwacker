using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class RejectAttackMixinV2 : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] attackTags;
        [JsonProperty] public readonly float limitTime;
    }
}
