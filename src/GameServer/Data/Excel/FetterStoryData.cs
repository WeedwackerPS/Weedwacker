using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("FetterStoryExcelConfigData.json")]
    internal class FetterStoryData : FetterBaseClass
    {
        [JsonProperty] public readonly ulong storyTitleTextMapHash;
        [JsonProperty] public readonly ulong storyContextTextMapHash;
        [JsonProperty] public readonly ulong storyTitle2TextMapHash;
        [JsonProperty] public readonly ulong storyContext2TextMapHash;
        [JsonProperty] public readonly ulong[] tips;
        [JsonProperty] public readonly ulong storyTitleLockedTextMapHash;
        [JsonProperty] public readonly uint avatarId;
    }
}
