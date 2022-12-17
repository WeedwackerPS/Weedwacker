using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class FireUIEffect : ConfigAbilityAction
    {
        [JsonProperty] public readonly string effectPattern;
        [JsonProperty] public readonly string effectSlot;
    }
}
