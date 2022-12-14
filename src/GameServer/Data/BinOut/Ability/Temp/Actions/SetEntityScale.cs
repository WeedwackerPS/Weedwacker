using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetEntityScale : ConfigAbilityAction
    {
        [JsonProperty] public readonly float scale;
        [JsonProperty] public readonly bool canBeHandledOnRecover;
    }
}
