using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ServerMonsterLog : ConfigAbilityAction
    {
        [JsonProperty] public readonly int[] paramList;
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
