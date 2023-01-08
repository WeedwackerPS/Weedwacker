using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TriggerBullet : ConfigAbilityAction
    {
        [JsonProperty] public readonly int bulletID;
        [JsonProperty] public readonly ConfigBornType born;
        [JsonProperty] public readonly BaseDirectionType direction;
    }
}
