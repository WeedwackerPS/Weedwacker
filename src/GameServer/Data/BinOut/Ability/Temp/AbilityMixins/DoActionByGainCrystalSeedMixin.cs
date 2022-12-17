using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoActionByGainCrystalSeedMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ElementType[] elementTypes;
        [JsonProperty] public readonly bool doOffStage;
        [JsonProperty] public readonly ConfigAbilityAction[] actions;
    }
}
