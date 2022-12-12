using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class PlatformMoveMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] moveModifiers;
    }
}
