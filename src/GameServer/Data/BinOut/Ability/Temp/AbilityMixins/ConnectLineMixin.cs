using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ConnectLineMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string RepeaterModifier;
        [JsonProperty] public readonly string CollectorModifier;
        [JsonProperty] public readonly string CollectorGlobalvalueKey;
    }
}
