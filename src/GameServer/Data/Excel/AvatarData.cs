using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarExcelConfigData.json")]
    internal class AvatarData
    {
        [JsonProperty] public readonly string? iconName;
        [JsonProperty] public readonly string? sideIconName;
        [JsonProperty] public readonly string? bodyType;
        [JsonProperty] public readonly string? qualityType;
        [JsonProperty] public readonly double chargeEfficiency;
        [JsonProperty] public readonly uint initialWeapon;
        [JsonProperty] public readonly WeaponType weaponType;
        [JsonProperty] public readonly string? imageName;
        [JsonProperty] public readonly uint avatarPromoteId;
        [JsonProperty] public readonly string? cutsceneShow;
        [JsonProperty] public readonly uint skillDepotId;
        [JsonProperty] public readonly double staminaRecoverSpeed;
        [JsonProperty] public readonly uint[] candSkillDepotIds;
        [JsonProperty] public readonly uint manekinMotionConfig;
        [JsonProperty] public readonly string? avatarIdentityType;
        [JsonProperty] public readonly List<uint>? avatarPromoteRewardLevelList;
        [JsonProperty] public readonly List<uint>? avatarPromoteRewardIdList;
        [JsonProperty] public readonly uint featureTagGroupID;
        [JsonProperty] public readonly ulong nameTextMapHash;
        [JsonProperty] public readonly float hpBase;
        [JsonProperty] public readonly float attackBase;
        [JsonProperty] public readonly float defenseBase;
        [JsonProperty] public readonly float critical;
        [JsonProperty] public readonly float criticalHurt;
        [JsonProperty] public readonly List<PropGrowCurve>? propGrowCurves;
        [JsonProperty] public readonly uint id;
        [JsonProperty] public readonly string? LODPatternName;
    }
}
