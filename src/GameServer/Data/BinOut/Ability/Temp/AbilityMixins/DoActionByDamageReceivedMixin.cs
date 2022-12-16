using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoActionByDamageReceivedMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string paramType;
        [JsonProperty] public readonly float valueMin;
        [JsonProperty] public readonly float valueMax;
        [JsonProperty] public readonly ConfigAbilityAction[] actionQueue;
    }
}
