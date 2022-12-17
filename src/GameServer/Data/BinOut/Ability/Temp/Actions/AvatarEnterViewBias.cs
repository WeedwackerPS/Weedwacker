using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AvatarEnterViewBias : ConfigAbilityAction
    {
        [JsonProperty] public readonly int sphereBiasPole;
        [JsonProperty] public readonly int sphereBiasElev;
        [JsonProperty] public readonly int sphereRadius;
        [JsonProperty] public readonly int postForwardPoleDeltaAngle;
        [JsonProperty] public readonly int postForwardElevDeltaAngle;
        [JsonProperty] public readonly bool lockZoom;
        [JsonProperty] public readonly bool lockResetBack;
    }
}
