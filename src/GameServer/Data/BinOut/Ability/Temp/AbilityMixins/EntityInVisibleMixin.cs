using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class EntityInVisibleMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string reason;
        [JsonProperty] public readonly bool disableAudio;
    }
}
