using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarFettersLevelExcelConfigData.json")]
    public class AvatarFetterLevelData
    {
        [JsonProperty] public readonly uint fetterLevel;
        [JsonProperty] public readonly uint needExp;
    }
}
