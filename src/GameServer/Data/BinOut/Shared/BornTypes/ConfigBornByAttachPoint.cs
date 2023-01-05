using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes
{
    internal class ConfigBornByAttachPoint : BaseBornType
    {
        [JsonProperty] public readonly string attachPointName;
    }
}
