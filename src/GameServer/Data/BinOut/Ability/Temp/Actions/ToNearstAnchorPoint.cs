using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ToNearstAnchorPoint : ConfigAbilityAction
    {
        [JsonProperty] public readonly TargetType target;
    }
}
