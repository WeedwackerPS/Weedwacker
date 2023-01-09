using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("FetterCharacterCardExcelConfigData.json")]
    internal class FetterCharacterCardData
    {
        [JsonProperty] public readonly uint avatarId;
        [JsonProperty] public readonly uint fetterLevel;
        [JsonProperty] public readonly uint rewardId;
    }
}
