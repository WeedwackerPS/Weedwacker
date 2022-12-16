using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetCombatFixedMovePoint : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool setPoint;
        [JsonProperty] public readonly BaseBornType toPos;
    }
}
