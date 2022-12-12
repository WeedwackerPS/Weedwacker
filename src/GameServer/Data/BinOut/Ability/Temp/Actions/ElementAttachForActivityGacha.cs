using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ElementAttachForActivityGacha : BaseAction
    {
        [JsonProperty] public readonly ElementType element;
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
