using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TriggerAttackEvent : ConfigAbilityAction
    {
        [JsonProperty] public readonly TargetType targetType;
        [JsonProperty] public readonly bool doOffStage;
        [JsonProperty] public readonly ConfigAttackEvent attackEvent;
    }
}
