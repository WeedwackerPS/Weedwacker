using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity
{
    internal class ConfigDither
    {
        [JsonProperty] public readonly float showDitherDuration;
        [JsonProperty] public readonly ConfigDitherByStartDitherAction startDitherAction;
        [JsonProperty] public readonly ConfigDitherByBetweenCameraAndAvatar betweenCameraAndAvatar;
        [JsonProperty] public readonly ConfigDitherByNormalBetweenCamera normalBetweenCamera;

        public class ConfigDitherByStartDitherAction
        {
            [JsonProperty] public readonly bool enable;
        }

        public class ConfigDitherByBetweenCameraAndAvatar
        {
            [JsonProperty] public readonly float detectDitherRange;
        }

        public class ConfigDitherByNormalBetweenCamera
        {
            [JsonProperty] public readonly float detectDitherRange;
        }
    }
}
