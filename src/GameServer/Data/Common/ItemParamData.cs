using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Common
{
    public class ItemParamData
    {
        [JsonProperty("id")] public uint id { get; set; }

        [JsonProperty("itemId")] private uint itemId { set { id = value; } }
        [JsonProperty("count")] public int count { get; set; }

        [JsonProperty("itemCount")] private int itemCount { set { count = value; } }

        public ItemParamData(uint itemId, int count)
        {
            id = itemId;
            this.count = count;
        }
    }
}
