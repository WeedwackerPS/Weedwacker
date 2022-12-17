using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TryTriggerPlatformStartMove : ConfigAbilityAction
    {
        [JsonProperty] public readonly float detectHeight;
        [JsonProperty] public readonly float detectWidth;
        [JsonProperty] public readonly ConfigAbilityAction[] failActions;
    }
}
