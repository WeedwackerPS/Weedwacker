using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class TriggerResistDamageTextMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ElementType[] elementTypes;
    }
}
