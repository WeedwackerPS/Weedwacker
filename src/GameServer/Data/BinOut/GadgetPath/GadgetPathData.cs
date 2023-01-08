using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.GadgetPath
{
    internal class GadgetPathData
    {
        [JsonProperty] public readonly Dictionary<string, string[]> gadgetPaths;
    }
}
