using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DynamicCollisionMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] tags;
        [JsonProperty] public readonly bool isChecker;
    }
}
