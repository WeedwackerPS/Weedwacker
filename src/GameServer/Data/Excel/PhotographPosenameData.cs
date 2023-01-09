using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("PhotographPosenameExcelConfigData.json")]
    internal class PhotographPosenameData : FetterBaseClass
    {
        [JsonProperty] public readonly string poseFile;
        [JsonProperty] public readonly string poseIcon;
        [JsonProperty] public readonly ulong poseNameTextMapHash;
        [JsonProperty] public readonly ulong unlockDescTextMapHash;
        [JsonProperty] public readonly uint avatarId;
    }
}
