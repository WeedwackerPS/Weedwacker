using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class CreateTile : ConfigAbilityAction
    {
        [JsonProperty] public readonly string tileName;
        [JsonProperty] public readonly BaseAttackPattern attackPattern;
    }
}
