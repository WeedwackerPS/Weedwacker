using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes
{
    internal class ConfigBornByWorld : BaseBornType
    {
        [JsonProperty] public readonly Dictionary<string, float> worldPos;
    }
}
