using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class RemoveUniqueModifier : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool? doOffStage;
        [JsonProperty] public readonly string modifierName;
    }
}
