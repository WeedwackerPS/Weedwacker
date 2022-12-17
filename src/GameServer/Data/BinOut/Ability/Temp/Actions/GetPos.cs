using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class GetPos : ConfigAbilityAction
    {
        [JsonProperty] public readonly string key;
        [JsonProperty] public readonly string posType;
    }
}
