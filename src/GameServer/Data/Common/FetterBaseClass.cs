using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;

namespace Weedwacker.GameServer.Data
{
    internal class FetterBaseClass
    {
        [JsonProperty] public readonly uint fetterId;
        [JsonProperty] public readonly FetterCond[] openConds;
        [JsonProperty] public readonly FetterCond[] finishConds;

    }
}
