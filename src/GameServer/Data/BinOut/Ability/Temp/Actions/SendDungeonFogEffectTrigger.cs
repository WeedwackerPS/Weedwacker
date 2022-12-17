using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SendDungeonFogEffectTrigger : ConfigAbilityAction
    {
        [JsonProperty] public readonly string parameter;
        [JsonProperty] public readonly string cameraFogEffectName;
    }
}
