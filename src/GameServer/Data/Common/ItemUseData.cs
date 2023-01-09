using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Common
{
    internal class ItemUseData
    {
        [JsonProperty] public readonly ItemUseOp useOp;
        [JsonProperty] public readonly string[] useParam;
    }
}
