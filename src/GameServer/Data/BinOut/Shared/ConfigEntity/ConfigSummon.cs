using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity
{
    internal class ConfigSummon
    {
        [JsonProperty] public readonly ConfigSummonTag[] summonTags;

        public class ConfigSummonTag
        {
            [JsonProperty] public readonly int summonTag;
            [JsonProperty] public readonly string name;
            [JsonProperty] public readonly int maxNum;
            [JsonProperty] public readonly bool copyOwnerThreatList;
            [JsonProperty] public readonly bool useOwnerDefendArea;
        }
    }
}
