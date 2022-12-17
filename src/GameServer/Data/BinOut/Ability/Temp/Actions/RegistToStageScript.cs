using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class RegistToStageScript : ConfigAbilityAction
    {
        [JsonProperty] public readonly string alias;
        [JsonProperty] public readonly bool canBeHandledOnRecover;
    }
}
