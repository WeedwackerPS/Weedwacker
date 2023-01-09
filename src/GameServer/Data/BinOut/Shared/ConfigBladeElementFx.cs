using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared
{
    internal class ConfigBladeElementFx
    {
        [JsonProperty] public readonly string slash;
        [JsonProperty] public readonly string colorA;
        [JsonProperty] public readonly string colorB;
    }
}
