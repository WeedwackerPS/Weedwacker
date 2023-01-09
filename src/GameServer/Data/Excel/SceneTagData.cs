using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("SceneTagConfigData.json")]
    internal class SceneTagData
    {
        [JsonProperty] public readonly uint id;
        [JsonProperty] public readonly string sceneTagName;
        [JsonProperty] public readonly uint sceneId;
        [JsonProperty] public readonly bool isDefaultValid;
        //TODO Missing one field 
        [JsonProperty] public readonly TagCond[] cond;

        public class TagCond
        {
            [JsonProperty] public readonly SceneTagCondType condType;
            [JsonProperty] public readonly int param1;
            [JsonProperty] public readonly int? param2;
        }
    }
}
