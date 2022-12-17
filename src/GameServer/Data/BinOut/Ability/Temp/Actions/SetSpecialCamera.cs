using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetSpecialCamera : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool enable;
        [JsonProperty] public readonly string specialCameraName;
    }
}
