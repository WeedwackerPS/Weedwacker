using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class FireEffect : ConfigAbilityAction
    {
        [JsonProperty] public readonly string effectPattern;
    }
}
