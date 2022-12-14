using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TriggerSetShadowRamp : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool useShadowRamp;
        [JsonProperty] public readonly bool? doOffStage;
        [JsonProperty] public readonly string[] specialMats;
    }
}
