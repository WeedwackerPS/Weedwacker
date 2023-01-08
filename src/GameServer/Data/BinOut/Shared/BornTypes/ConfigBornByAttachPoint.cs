using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes
{
    internal class ConfigBornByAttachPoint : ConfigBornType
    {
        [JsonProperty] public readonly string attachPointName;
    }
}
