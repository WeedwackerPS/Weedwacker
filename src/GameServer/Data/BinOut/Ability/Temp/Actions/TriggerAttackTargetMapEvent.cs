using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TriggerAttackTargetMapEvent : ConfigAbilityAction
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly AttackTargetMapEvent attackTargetMapEvent;

        public class AttackTargetMapEvent
        {
            [JsonProperty] public readonly BaseAttackPattern attackPattern;
            [JsonProperty] public readonly Dictionary<TargetType, AttackInfo> attackInfoMap;
        }
    }
}
