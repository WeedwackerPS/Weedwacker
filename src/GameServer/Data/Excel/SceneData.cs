using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("SceneExcelConfigData.json")]
    internal class SceneData
    {
        [JsonProperty] public readonly uint id;
        [JsonProperty] public readonly SceneType type;
        [JsonProperty] public readonly string scriptData;
        [JsonProperty] public readonly string overrideDefaultProfile;
        [JsonProperty] public readonly string levelEntityConfig;
        [JsonProperty] public readonly uint[] specifiedAvatarList;
        [JsonProperty] public readonly uint safePoint;
    }
}
