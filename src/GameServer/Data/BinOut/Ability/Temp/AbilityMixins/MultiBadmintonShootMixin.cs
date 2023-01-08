using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class MultiBadmintonShootMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly float minInterval;
        [JsonProperty] public readonly float maxInterval;
        [JsonProperty] public readonly int extraShootInterval;
        [JsonProperty] public readonly string[] extraShootTag;
        [JsonProperty] public readonly int normalBulletID;
        [JsonProperty] public readonly int tresBulletID;
        [JsonProperty] public readonly string[] traceTarget;
        [JsonProperty] public readonly int perChangeWeight;
        [JsonProperty] public readonly ConfigBornType born;
        [JsonProperty] public readonly BaseBulletType[] bullets;
    }
}
