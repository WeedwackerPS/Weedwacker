using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachToElementTypeMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ElementType[] elementTypes;
        [JsonProperty] public readonly string modifierName;
    }
}
