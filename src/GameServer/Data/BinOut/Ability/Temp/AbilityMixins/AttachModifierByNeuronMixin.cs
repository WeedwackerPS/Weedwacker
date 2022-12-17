using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachModifierByNeuronMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] neuronNameList;
        [JsonProperty] public readonly string modifierName;
        [JsonProperty] public readonly bool authorityOnly;
        [JsonProperty] public readonly string removeOperator;
    }
}
