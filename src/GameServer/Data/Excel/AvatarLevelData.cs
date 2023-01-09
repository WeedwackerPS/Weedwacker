using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarLevelExcelConfigData.json")]
    internal class AvatarLevelData
    {
        [JsonProperty] public readonly uint Level;
        [JsonProperty] public readonly uint Exp;
    }
}
