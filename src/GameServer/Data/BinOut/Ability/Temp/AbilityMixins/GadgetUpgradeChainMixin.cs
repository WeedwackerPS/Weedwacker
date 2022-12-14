using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class GadgetUpgradeChainMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string globalValueKey;
    }
}
