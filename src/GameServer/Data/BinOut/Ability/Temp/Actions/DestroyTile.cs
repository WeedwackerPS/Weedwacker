using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class DestroyTile : ConfigAbilityAction
    {
        [JsonProperty] public readonly string tileName;
        [JsonProperty] public readonly BaseAttackPattern attackPattern;
    }
}
