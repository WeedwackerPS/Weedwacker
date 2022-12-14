using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class BroadcastNeuronStimulate : ConfigAbilityAction
    {
        [JsonProperty] public readonly string neuronName;
        [JsonProperty] public readonly bool stimulate;
        [JsonProperty] public readonly float range;
    }
}
