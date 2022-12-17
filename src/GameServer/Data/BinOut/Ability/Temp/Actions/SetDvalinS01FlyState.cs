using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetDvalinS01FlyState : ConfigAbilityAction
    {
        [JsonProperty] public readonly int toState;
        [JsonProperty] public readonly bool canBeHandledOnRecover;
    }
}
