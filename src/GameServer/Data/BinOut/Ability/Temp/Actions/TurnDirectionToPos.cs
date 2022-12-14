using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TurnDirectionToPos : ConfigAbilityAction
    {
        [JsonProperty] public readonly BaseBornType toPos;
    }
}
