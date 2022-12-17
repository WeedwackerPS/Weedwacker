using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class RelyOnElementMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ElementType elementType;
    }
}
