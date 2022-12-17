using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TriggerSetVisible : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool doOffStage;
        [JsonProperty] public readonly bool visible;
    }
}
