using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigFormulaicMove : ConfigMove
    {
        [JsonProperty] public readonly UgcTimeControlType timeControl;
        [JsonProperty] public readonly UgcFormulaType formulaType;
        [JsonProperty] public readonly UgcMoveType moveMode;
        [JsonProperty] public readonly float[] offTime;
        [JsonProperty] public readonly bool automaticMove;
        [JsonProperty] public readonly UgcAxialType polar;
        [JsonProperty] public readonly float[] angleSection;
        [JsonProperty] public readonly float angleStep;
        [JsonProperty] public readonly bool isClockWise;
        [JsonProperty] public readonly float angleSpeed;
        [JsonProperty] public readonly float[] period;
        [JsonProperty] public readonly Vector[] route;
    }
}
