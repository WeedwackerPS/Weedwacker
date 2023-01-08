using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetCombatFixedMovePoint : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool setPoint;
        [JsonProperty] public readonly ConfigBornType toPos;
    }
}
