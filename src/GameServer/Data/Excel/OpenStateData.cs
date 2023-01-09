using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("OpenStateConfigData.json")]
    internal class OpenStateData
    {
        [JsonProperty] public readonly uint id; // maps to OpenStateType enum
        [JsonProperty] public readonly bool defaultState;
        [JsonProperty] public readonly bool allowClientOpen;
        [JsonProperty] public readonly uint systemOpenUiId;
        [JsonProperty] public readonly OpenStateCond[] cond;

        public class OpenStateCond
        {
            [JsonProperty] public readonly OpenStateCondType condType;
            [JsonProperty] public readonly int param;
            [JsonProperty] public readonly int param2;
        }
    }
}
