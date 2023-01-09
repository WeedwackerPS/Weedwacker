using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("DungeonExcelConfigData.json")]
    internal class DungeonData
    {
        [JsonProperty] public readonly uint id;
        [JsonProperty] public readonly ulong nameTextMapHash;
        [JsonProperty] public readonly ulong displayNameTextMapHash;
        [JsonProperty] public readonly ulong descTextMapHash;
        [JsonProperty] public readonly DungeonType type;
        [JsonProperty] public readonly uint sceneId;
        [JsonProperty] public readonly DungeonInvolveType involveType;
        [JsonProperty] public readonly uint showLevel;
        [JsonProperty] public readonly uint limitLevel;
        [JsonProperty] public readonly uint levelRevise;
        [JsonProperty] public readonly uint passCond; // should be an enum?
        [JsonProperty] public readonly uint reviveMaxCount;
        [JsonProperty] public readonly uint dayEnterCount;
        //[JsonProperty] public readonly ???[] enterCostItems; // unused?
        [JsonProperty] public readonly uint passRewardPreviewId;
        [JsonProperty] public readonly int settleCountdownTime;
        [JsonProperty] public readonly int failSettleCountdownTime;
        [JsonProperty] public readonly int quitSettleCountdownTime;
        [JsonProperty] public readonly SettleShowType[] settleShows;
        [JsonProperty] public readonly uint statueCostId;
        [JsonProperty] public readonly int statueCostCount;
        [JsonProperty] public readonly uint statueDrop;
        [JsonProperty] public readonly bool forbiddenRestart;
        [JsonProperty] public readonly string settleUIType;
        [JsonProperty] public readonly ElementType[] recommendElementTypes;
        [JsonProperty] public readonly Dictionary<string, int> levelConfigMap;
        [JsonProperty] public readonly uint[] previewMonsterList;
        [JsonProperty] public readonly long gearDescTextMapHash;
        [JsonProperty] public readonly uint cityId;
        [JsonProperty] public readonly string entryPicPath;
        [JsonProperty] public readonly DungeonStateType stateType;
        [JsonProperty] public readonly string factorPic;
        [JsonProperty] public readonly string factorIcon;
    }
}
