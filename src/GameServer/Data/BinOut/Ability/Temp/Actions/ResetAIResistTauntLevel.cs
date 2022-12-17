using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ResetAIResistTauntLevel : ConfigAbilityAction
    {
        [JsonProperty] public readonly string resistTauntLevel;
        [JsonProperty] public readonly bool canBeHandledOnRecover;
    }
}
