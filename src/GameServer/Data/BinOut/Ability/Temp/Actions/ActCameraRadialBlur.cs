using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ActCameraRadialBlur : ConfigAbilityAction
    {
        [JsonProperty] public readonly Blur cameraRadialBlur;

        public class Blur
        {
            [JsonProperty] public readonly float power;
            [JsonProperty] public readonly float blurTime;
            [JsonProperty] public readonly float fadeTime;
        }
    }
}
