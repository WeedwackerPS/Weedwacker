using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.SelectTargetType
{
    internal class SelectTargetsBySelfGroup : BaseSelectTargetType
    {
        [JsonProperty] public readonly OperationType operation;
        [JsonProperty] public readonly int value;
        [JsonProperty] public readonly CompareType compareType;
    }
}
