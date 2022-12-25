using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TryTriggerTrampolineJump : ConfigAbilityAction
    {
        [JsonProperty] public readonly ConfigAbilityAction[] failActions;
    }
}
