using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachToGadgetStateMutexMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int[] gadgetStates;
        [JsonProperty] public readonly string[][] modifierNames;
    }
}
