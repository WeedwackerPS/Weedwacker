using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AttachModifier : ConfigAbilityAction
    {
        [JsonProperty] public readonly string modifierName;
    }
}
