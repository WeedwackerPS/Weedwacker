using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DiePatternSwitchMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string priority;
        [JsonProperty] public readonly bool startDieEndAtOnce;
        [JsonProperty] public readonly bool ignoreElementDie;
        [JsonProperty] public readonly bool notSendDieTrigger;
        [JsonProperty] public readonly string dieDisappearEffect;
        [JsonProperty] public readonly float dieDisappearEffectDelay;
        [JsonProperty] public readonly float dieEndTime;
        [JsonProperty] public readonly float dieForceDisappearTime;
        [JsonProperty] public readonly float dieModelFadeDelay;
        [JsonProperty] public readonly bool muteHitBox;
        [JsonProperty] public readonly bool dieDenyLockOn;
        [JsonProperty] public readonly bool dieIsGhostToEnemy;
        [JsonProperty] public readonly bool dieIgnoreTriggerBullet;
        [JsonProperty] public readonly bool muteBillboard;
        [JsonProperty] public readonly bool mutePushCollider;
    }
}
