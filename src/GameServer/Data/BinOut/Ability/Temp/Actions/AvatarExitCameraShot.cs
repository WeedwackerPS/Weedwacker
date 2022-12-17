using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AvatarExitCameraShot : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool doOffStage;
    }
}
