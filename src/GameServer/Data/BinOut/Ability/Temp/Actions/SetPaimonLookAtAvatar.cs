using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetPaimonLookAtAvatar : ConfigAbilityAction
    {
        [JsonProperty] public readonly string from;
        [JsonProperty] public readonly bool lookat;
        [JsonProperty] public readonly float minTime;
        [JsonProperty] public readonly float maxTime;
    }
}
