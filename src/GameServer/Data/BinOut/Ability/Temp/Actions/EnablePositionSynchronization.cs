using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnablePositionSynchronization : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool canBeHandledOnRecover;
        [JsonProperty] public readonly bool enable;
    }
}
