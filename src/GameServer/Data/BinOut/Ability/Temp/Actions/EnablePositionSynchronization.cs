using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnablePositionSynchronization : BaseAction
    {
        [JsonProperty] public readonly bool canBeHandledOnRecover;
        [JsonProperty] public readonly bool enable;
    }
}
