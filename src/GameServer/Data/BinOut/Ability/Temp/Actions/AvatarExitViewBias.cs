using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AvatarExitViewBias : ConfigAbilityAction
    {
        [JsonProperty] public readonly float lerpRadius;
        [JsonProperty] public readonly float lerpDuration;
        [JsonProperty] public readonly bool doOffStage;
    }
}
