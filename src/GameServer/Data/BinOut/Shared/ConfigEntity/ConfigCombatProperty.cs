using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity
{
    internal class ConfigCombatProperty
    {
        [JsonProperty] public readonly EndureType endureType;
        [JsonProperty] public readonly bool useCreatorProperty;
        [JsonProperty] public readonly CombatPropertyIndex[] useCreatorPropertyPartly;
        [JsonProperty] public readonly bool useCreatorBuffedProperty;
        [JsonProperty] public readonly bool useAbilityProperty;
        [JsonProperty] public readonly float hp;
        [JsonProperty] public readonly float attack;
        [JsonProperty] public readonly float defense;
        [JsonProperty] public readonly int level;
        [JsonProperty] public readonly LevelOption levelOption;
        [JsonProperty] public readonly float weight;
        [JsonProperty] public readonly float endureShake;
        [JsonProperty] public readonly bool isInvincible;
        [JsonProperty] public readonly bool isLockHp;
        [JsonProperty] public readonly bool isLockHpNoHeal;
        [JsonProperty] public readonly bool isNoHeal;
        [JsonProperty] public readonly bool isGhostToAllied;
        [JsonProperty] public readonly bool isGhostToEnemy;
        [JsonProperty] public readonly bool canTriggerBullet;
        [JsonProperty] public readonly bool denyElementStick;
        [JsonProperty] public readonly bool ignorePurgeRate;
        [JsonProperty] public readonly bool ignoreDamageToSelf;
    }
}
