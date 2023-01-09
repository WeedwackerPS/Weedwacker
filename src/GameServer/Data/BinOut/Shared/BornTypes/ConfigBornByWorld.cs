using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes
{
    internal class ConfigBornByWorld : ConfigBornType
    {
        [JsonProperty] public readonly Dictionary<string, float> worldPos;
    }
}
