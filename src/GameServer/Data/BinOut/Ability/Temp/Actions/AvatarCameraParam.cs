using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AvatarCameraParam : ConfigAbilityAction
    {
        [JsonProperty] public readonly CamParam cameraParam;

        public class CamParam
        {
            [JsonProperty] public readonly float forceRadius;
            [JsonProperty] public readonly float forceRadiusDuration;
            [JsonProperty] public readonly bool shouldKeepForceRadius;
        }
    }
}
