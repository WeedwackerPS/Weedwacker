using System.Numerics;
using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("MonsterExcelConfigData.json")]
    internal class MonsterData
    {
        [JsonProperty] public readonly string monsterName;
        [JsonProperty] public readonly MonsterType type;
        [JsonProperty] public readonly SecurityLevel securityLevel;
        [JsonProperty] public readonly BigInteger scriptDataPathHashSuffix;
        [JsonProperty] public readonly uint scriptDataPathHashPre;
        [JsonProperty] public readonly string serverScript;
        [JsonProperty] public readonly BigInteger combatConfigHashSuffix;
        [JsonProperty] public readonly uint combatConfigHashPre;
        [JsonProperty] public readonly uint[] affix;
        [JsonProperty] public readonly string ai;
        [JsonProperty] public readonly bool isAIHashCheck;
        [JsonProperty] public readonly uint[] equips;
        [JsonProperty] public readonly HpDrop[] hpDrops;
        [JsonProperty] public readonly uint killDropId;
        [JsonProperty] public readonly VisionLevel visionLevel;
        [JsonProperty] public readonly string excludeWeathers;
        [JsonProperty] public readonly uint featureTagGroupId;
        [JsonProperty] public readonly uint mpPropId;
        [JsonProperty] public readonly string skin;
        [JsonProperty] public readonly uint describeId;
        [JsonProperty] public readonly uint combatBGMLevel;
        [JsonProperty] public readonly uint entityBudgetLevel;
        [JsonProperty] public readonly float hpBase;
        [JsonProperty] public readonly float attackBase;
        [JsonProperty] public readonly float defenseBase;
        [JsonProperty] public readonly float fireSubHurt;
        [JsonProperty] public readonly float grassSubHurt;
        [JsonProperty] public readonly float waterSubHurt;
        [JsonProperty] public readonly float elecSubHurt;
        [JsonProperty] public readonly float windSubHurt;
        [JsonProperty] public readonly float iceSubHurt;
        [JsonProperty] public readonly float rockSubHurt;
        [JsonProperty] public readonly PropGrowCurve[] propGrowCurves;
        [JsonProperty] public readonly float physicalSubHurt;
        [JsonProperty] public readonly BigInteger prefabPathRagdollHashSuffix;
        [JsonProperty] public readonly uint prefabPathRagdollHashPre;
        [JsonProperty] public readonly uint id;
        [JsonProperty] public readonly ulong nameTextMapHash;
        [JsonProperty] public readonly BigInteger prefabPathHashSuffix;
        [JsonProperty] public readonly uint prefabPathHashPre;
        [JsonProperty] public readonly ulong prefabPathRemoteHashSuffix;
        [JsonProperty] public readonly uint prefabPathRemoteHashPre;
        [JsonProperty] public readonly ulong controllerPathHashSuffix;
        [JsonProperty] public readonly BigInteger controllerPathHashPre;
        [JsonProperty] public readonly BigInteger controllerPathRemoteHashSuffix;
        [JsonProperty] public readonly BigInteger controllerPathRemoteHashPre;
        [JsonProperty] public readonly uint campId;
        [JsonProperty] public readonly string lODPatternName;

        public class HpDrop
        {
            [JsonProperty] public readonly int dropId;
            [JsonProperty] public readonly float hpPercent;
        }
    }

}
