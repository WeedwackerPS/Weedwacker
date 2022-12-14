using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TriggerSetRenderersEnable : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool doOffStage;
        [JsonProperty] public readonly bool canBeHandledOnRecover;
        [JsonProperty] public readonly string[] renderNames;
        [JsonProperty] public readonly bool setEnable;
    }
}
