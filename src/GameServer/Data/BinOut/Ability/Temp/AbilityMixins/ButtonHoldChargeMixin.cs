using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ButtonHoldChargeMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int overtime;
        [JsonProperty] public readonly float chargeTime;
        [JsonProperty] public readonly object secondChargeTime;
        [JsonProperty] public readonly ConfigAbilityAction[]? OnBeginUncharged;
        [JsonProperty] public readonly ConfigAbilityAction[]? OnReleaseUncharged;
        [JsonProperty] public readonly ConfigAbilityAction[]? OnBeginCharged;
        [JsonProperty] public readonly ConfigAbilityAction[]? OnReleaseCharged;
        [JsonProperty] public readonly ConfigAbilityAction[]? OnBeginSecondCharged;
        [JsonProperty] public readonly string[] chargeStateIDs;
    }
}
