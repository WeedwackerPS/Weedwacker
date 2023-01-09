using Newtonsoft.Json;
using static Weedwacker.GameServer.Data.ResourceAttribute;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarSkillDepotExcelConfigData.json")]
    internal class AvatarSkillDepotData
    {
        [JsonProperty] public readonly uint id;
        [JsonProperty] public readonly uint energySkill;
        [JsonProperty] public readonly uint attackModeSkill;
        [JsonProperty] public readonly uint[] skills;
        [JsonProperty] public readonly uint[] subSkills;
        [JsonProperty] public readonly uint leaderTalent;
        [JsonProperty] public readonly string[] extraAbilities;
        [JsonProperty] public readonly uint[] talents;
        [JsonProperty] public readonly InherentProudSkillOpens[] inherentProudSkillOpens;
        [JsonProperty] public readonly string? talentStarName;
        [JsonProperty] public readonly string? skillDepotAbilityGroup;

        public class InherentProudSkillOpens
        {
            [JsonProperty] public readonly uint? proudSkillGroupId;
            [JsonProperty] public readonly uint? needAvatarPromoteLevel;
        }
    }
}
