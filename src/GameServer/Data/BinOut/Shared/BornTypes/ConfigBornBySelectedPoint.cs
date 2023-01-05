using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes
{
    internal class ConfigBornBySelectedPoint : BaseBornType
    {
        [JsonProperty] public readonly bool onGround;
    }
}
