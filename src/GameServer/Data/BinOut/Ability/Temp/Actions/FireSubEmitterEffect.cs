using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class FireSubEmitterEffect : ConfigAbilityAction
    {
        [JsonProperty] public readonly string effectPattern;
        [JsonProperty] public readonly ConfigBornType born;
    }
}
