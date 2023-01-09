using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("FettersExcelConfigData.json")]
    internal class FettersData : FetterBaseClass
    {
        [JsonProperty] public readonly uint type;
        [JsonProperty] public readonly uint[] costumeIds;
        [JsonProperty] public readonly ulong[] tips;
        [JsonProperty] public readonly ulong voiceTitleTextMapHash;
        [JsonProperty] public readonly uint? voiceFile;
        [JsonProperty] public readonly ulong voiceFileTextTextMapHash;
        [JsonProperty] public readonly ulong voiceTitleLockedTextMapHash;
        [JsonProperty] public readonly uint avatarId;
    }
}
