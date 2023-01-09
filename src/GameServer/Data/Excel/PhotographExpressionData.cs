using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("PhotographExpressionExcelConfigData.json")]
    internal class PhotographExpressionData : FetterBaseClass
    {
        [JsonProperty] public readonly string emotionName;
        [JsonProperty] public readonly string phonemeName;
        [JsonProperty] public readonly string icon;
        [JsonProperty] public readonly ulong emotionDescriptionTextMapHash;
        [JsonProperty] public readonly ulong unlockDescTextMapHash;
        [JsonProperty] public readonly uint avatarId;
    }
}
