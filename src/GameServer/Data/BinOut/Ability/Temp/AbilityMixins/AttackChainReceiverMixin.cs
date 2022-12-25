using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttackChainReceiverMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly object cd;
        [JsonProperty] public readonly ConfigAbilityAction[] actionQueue;
    }
}
