using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class FireEffectForStorm : ConfigAbilityAction
    {
        [JsonProperty] public readonly float height;
        [JsonProperty] public readonly ConfigBornType born;
    }
}
