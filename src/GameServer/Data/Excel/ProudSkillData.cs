using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("ProudSkillExcelConfigData.json")]
    public class ProudSkillData
    {
        [JsonProperty] public readonly uint proudSkillId;
        [JsonProperty] public readonly uint proudSkillGroupId;
        [JsonProperty] public readonly uint level;
        [JsonProperty] public readonly int coinCost;
        [JsonProperty] public readonly uint breakLevel;
        [JsonProperty] public readonly int proudSkillType;
        [JsonProperty] public readonly int effectiveForTeam;
        [JsonProperty] public readonly string openConfig;
        [JsonProperty] public readonly string icon;
        [JsonProperty] public readonly ItemParamData[] costItems;
        [JsonProperty] public readonly TalentFilter[] filterConds;
        [JsonProperty] public readonly string[] lifeEffectParams;
        [JsonProperty] public readonly FightPropData[] addProps;
        [JsonProperty] public readonly double[] paramList;
        [JsonProperty] public readonly long[] paramDescList;
        [JsonProperty] public readonly long nameTextMapHash;

        public List<ItemParamData> GetTotalCostItems()
        {
            List<ItemParamData> total = new();
            total = (List<ItemParamData>)total.Concat(costItems);
            if (coinCost > 0)
                total.Add(new ItemParamData(202, coinCost));

            return total;
        }
    }
}
