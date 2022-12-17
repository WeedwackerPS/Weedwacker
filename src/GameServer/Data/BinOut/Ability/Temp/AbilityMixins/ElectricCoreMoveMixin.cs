using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ElectricCoreMoveMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly float stageOnceVelocity;
        [JsonProperty] public readonly float stageOneAccelerate;
        [JsonProperty] public readonly float stageTwoVelocity;
        [JsonProperty] public readonly float stageTwoAttenuation;
        [JsonProperty] public readonly float maxAbsorbTime;
        [JsonProperty] public readonly BaseBornType toPos;
        [JsonProperty] public readonly ConfigAbilityAction[] onCoreEnter;
        [JsonProperty] public readonly ConfigAbilityAction[] onInterrupted;
        [JsonProperty] public readonly ConfigAbilityAction[] onStartSuccess;
    }
}
