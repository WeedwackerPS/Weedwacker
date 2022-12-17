using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class DoWidgetSystemAction : ConfigAbilityAction
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly string widgetEvent;
    }
}
