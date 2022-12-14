using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class InteractTriggerAbilityMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string abilityName;
    }
}
