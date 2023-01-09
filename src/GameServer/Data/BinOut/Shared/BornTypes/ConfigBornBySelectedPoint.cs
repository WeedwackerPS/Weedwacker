using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes
{
    internal class ConfigBornBySelectedPoint : ConfigBornType
    {
        [JsonProperty] public readonly bool onGround;
    }
}
