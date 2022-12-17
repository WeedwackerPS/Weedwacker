using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class DoTileAction : ConfigAbilityAction
    {
        [JsonProperty] public readonly string actionID;
    }
}
