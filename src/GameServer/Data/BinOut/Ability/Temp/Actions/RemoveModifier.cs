using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class RemoveModifier : ConfigAbilityAction
    {
        [JsonProperty] public readonly string modifierName;
    }
}
