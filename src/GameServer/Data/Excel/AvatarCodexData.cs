using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarCodexExcelConfigData.json")]
    internal class AvatarCodexData
    {
        [JsonProperty] public readonly uint sortId;
        [JsonProperty] public readonly int sortFactor;
        [JsonProperty] public readonly uint avatarId;
        [JsonProperty] public readonly string beginTime;
    }
}
