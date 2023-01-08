using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity
{
    internal class ConfigEntityCommon
    {
        [JsonProperty] public readonly ConfigEffectAttachShape effectAttachShape;
        [JsonProperty] public readonly float mass;
        [JsonProperty] public readonly float height;
        [JsonProperty] public readonly float modelHeight;
        [JsonProperty] public readonly float viewSize;
        [JsonProperty] public readonly float shadowViewSizeRatio;
        [JsonProperty] public readonly float overrideCullBoundsRadius;
        [JsonProperty] public readonly bool affectedByWorld;
        [JsonProperty] public readonly bool checkInSurface;
        [JsonProperty] public readonly float scale;
        [JsonProperty] public readonly float disableTickDistance;
        [JsonProperty] public readonly float forcePauseTickDistance;
        [JsonProperty] public readonly bool shouldPauseAnimatorBeforeReady;
        [JsonProperty] public readonly bool canTriggerElementReactionText;
        [JsonProperty] public readonly bool useGrassDisplacement;
        [JsonProperty] public readonly bool muteElementStickUi;
        [JsonProperty] public readonly bool hasAfterImage;
        [JsonProperty] public readonly bool useDynamicBone;
        [JsonProperty] public readonly bool enableCrashDamage;
        [JsonProperty] public readonly bool clearAnimatorOnSetLightDeactive;
        [JsonProperty] public readonly bool clearAiOnSetLightDeactive;
        [JsonProperty] public readonly bool useFinalIk;
        [JsonProperty] public readonly float elementReactionScale;
        [JsonProperty] public readonly float chargeBarHeightOffset;
    }
}
