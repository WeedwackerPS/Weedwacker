using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarSkillExcelConfigData.json")]
    internal class AvatarSkillData
    {
        [JsonProperty] public readonly uint id;
        [JsonProperty] public readonly double cdTime;
        [JsonProperty] public readonly float costElemVal;
        [JsonProperty] public readonly uint maxChargeNum;
        [JsonProperty] public readonly uint triggerID;
        [JsonProperty] public readonly bool isAttackCameraLock;
        [JsonProperty] public readonly string? dragType;
        [JsonProperty] public readonly bool showIconArrow;
        [JsonProperty] public readonly uint proudSkillGroupId;
        [JsonProperty] public readonly ElementType costElemType;
        [JsonProperty] public readonly ulong nameTextMapHash;
        [JsonProperty] public readonly ulong descTextMapHash;
        [JsonProperty] public readonly string? abilityName;
        [JsonProperty] public readonly string? skillIcon;
        [JsonProperty] public readonly bool isRanged;
        [JsonProperty] public readonly string? lockShape;
        [JsonProperty] public readonly bool needStore;
        [JsonProperty] public readonly string? buffIcon;
        [JsonProperty] public readonly double[] lockWeightParams;
        [JsonProperty] public readonly string? globalValueKey; // when this is not empty, set the avatar's global's value to energyMin
        [JsonProperty] public readonly float energyMin;
    }
}
