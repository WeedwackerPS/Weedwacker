using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TriggerAudio : ConfigAbilityAction
    {
        [JsonProperty] public readonly BaseEventOp operation;
    }
}
