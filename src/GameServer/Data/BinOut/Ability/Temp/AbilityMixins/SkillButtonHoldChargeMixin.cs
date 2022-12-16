using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class SkillButtonHoldChargeMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int overtime;
        [JsonProperty] public readonly string nextLoopTriggerID;
        [JsonProperty] public readonly string endHoldTrigger;
        [JsonProperty] public readonly string[] beforeStateIDs;
        [JsonProperty] public readonly string[] chargeLoopStateIDs;
        [JsonProperty] public readonly float[] chargeLoopDurations;
    }
}
