using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetMaterialParamFloatByTransform : ConfigAbilityAction
    {
        [JsonProperty] public readonly string matName;
        [JsonProperty] public readonly string patternName;
        [JsonProperty] public readonly bool useCurve;
        [JsonProperty] public readonly float lerpTime;
        [JsonProperty] public readonly int lerpCurveIndex;
        [JsonProperty] public readonly object value;
    }
}
