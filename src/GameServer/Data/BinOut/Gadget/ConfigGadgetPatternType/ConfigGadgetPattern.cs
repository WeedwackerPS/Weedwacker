using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetPatternType
{
    internal class ConfigGadgetPattern
    {
        [JsonProperty] public readonly ConfigCollision collision;
    }
}
