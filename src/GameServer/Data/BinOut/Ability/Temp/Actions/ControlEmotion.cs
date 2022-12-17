using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ControlEmotion : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool doOffStage;
        [JsonProperty] public readonly bool toggleBlink;
    }
}
