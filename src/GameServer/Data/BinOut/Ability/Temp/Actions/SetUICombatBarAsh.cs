using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetUICombatBarAsh : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool enable;
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
