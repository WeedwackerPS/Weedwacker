using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TurnDirection : ConfigAbilityAction
    {
        [JsonProperty] public readonly TurnMode turnMode;
    }
}
