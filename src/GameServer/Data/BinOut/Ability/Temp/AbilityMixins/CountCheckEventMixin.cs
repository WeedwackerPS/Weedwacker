using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class CountCheckEventMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string eventKey;
        [JsonProperty] public readonly float checkTime;
        [JsonProperty] public readonly int checkCount;
        [JsonProperty] public readonly ConfigAbilityAction[] actionQueue;
    }
}
