using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("ReliquaryLevelExcelConfigData.json")]
    internal class ReliquaryLevelData
    {
        [JsonProperty] public readonly uint rank;
        [JsonProperty] public readonly uint level;
        [JsonProperty] public readonly uint exp;
        [JsonProperty] public readonly RelicLevelProperty[] addProps;

        public class RelicLevelProperty
        {
            [JsonProperty] public readonly FightProperty propType;
            [JsonProperty] public readonly float value;
        }
    }
}
