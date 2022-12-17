using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{ 
    internal class ApplyCrystalModifier : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool doOffStage;
        [JsonProperty] public readonly int id;
        [JsonProperty] public readonly string modifierName;
    }
}
