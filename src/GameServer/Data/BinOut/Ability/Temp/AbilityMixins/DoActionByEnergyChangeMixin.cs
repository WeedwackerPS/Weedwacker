using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoActionByEnergyChangeMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ElementType[] elementTypes;
        [JsonProperty] public readonly bool doWhenEnergyMax;
        [JsonProperty] public readonly ConfigAbilityAction[] onGainEnergyByBall;
    }
}
