using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DvalinS01PathEffsMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int effectStart;
        [JsonProperty] public readonly int effectEnd;
        [JsonProperty] public readonly DvalinS01PathEffsInfo[] effInfos;
    }

    internal class DvalinS01PathEffsInfo
    {
        [JsonProperty] public readonly int flyState;
        [JsonProperty] public readonly string effectName;
        [JsonProperty] public readonly float intervalMax;
        [JsonProperty] public readonly float intervalMin;
        [JsonProperty] public readonly int numMax;
        [JsonProperty] public readonly int numMin;
        [JsonProperty] public readonly float rangeMax;
        [JsonProperty] public readonly float rangeMin;
        [JsonProperty] public readonly float eularMax;
        [JsonProperty] public readonly float eularMin;
    }
}
