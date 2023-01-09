using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Common
{
    public class FightPropData
    {
        [JsonProperty] public readonly FightProperty propType;
        [JsonProperty] public readonly float value;
    }
}
