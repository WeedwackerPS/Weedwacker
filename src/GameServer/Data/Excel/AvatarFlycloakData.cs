using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarFlycloakExcelConfigData.json")]
    public class AvatarFlycloakData
    {
        [JsonProperty] public readonly uint flycloakId;
        [JsonProperty] public readonly ulong nameTextMapHash;
        [JsonProperty] public readonly uint materialId;

    }
}
