using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetNeuronEnable : ConfigAbilityAction
    {
        [JsonProperty] public readonly string neuronName;
        [JsonProperty] public readonly bool enable;
    }
}
