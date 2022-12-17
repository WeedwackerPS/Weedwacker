using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class CostStaminaMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly object costStaminaDelta;
        [JsonProperty] public readonly ConfigAbilityAction[] onStaminaEmpty;
    }
}
