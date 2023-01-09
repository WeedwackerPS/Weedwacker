using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared
{
    internal class Vector
    {
        [JsonProperty] public readonly float x;
        [JsonProperty] public readonly float y;
        [JsonProperty] public readonly float z;
    }
}
