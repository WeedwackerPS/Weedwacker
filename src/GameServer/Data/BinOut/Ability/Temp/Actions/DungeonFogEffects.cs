using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class DungeonFogEffects : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool muteRemoteAction;
        [JsonProperty] public readonly bool? enable;
        [JsonProperty] public readonly bool? doOffStage;
        [JsonProperty] public readonly string cameraFogEffectName;
        [JsonProperty] public readonly string playerFogEffectName;
    }
}