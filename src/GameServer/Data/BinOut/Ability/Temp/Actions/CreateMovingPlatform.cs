using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class CreateMovingPlatform : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool lifeByOwnerIsAlive;
        [JsonProperty] public readonly ConfigBornType born;
        [JsonProperty] public readonly int gadgetID;
        [JsonProperty] public readonly int campID;
        [JsonProperty] public readonly TargetType campTargetType;
        [JsonProperty] public readonly bool byServer;
    }
}
