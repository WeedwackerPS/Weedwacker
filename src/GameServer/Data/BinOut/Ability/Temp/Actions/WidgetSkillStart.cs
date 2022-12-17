using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class WidgetSkillStart : ConfigAbilityAction
    {
        [JsonProperty] public readonly int itemId;
    }
}
