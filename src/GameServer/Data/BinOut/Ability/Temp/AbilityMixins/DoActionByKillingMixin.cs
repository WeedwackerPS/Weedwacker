using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoActionByKillingMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly double detectWindow;
        [JsonProperty] public readonly ConfigAbilityAction[] onKill;
    }
}
