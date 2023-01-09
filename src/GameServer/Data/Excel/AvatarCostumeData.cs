using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarCostumeExcelConfigData.json")]
    public class AvatarCostumeData
    {
        [JsonProperty] public readonly uint skinId;
        [JsonProperty] public readonly uint itemId;
        [JsonProperty] public readonly uint avatarId;
    }
}