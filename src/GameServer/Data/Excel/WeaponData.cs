using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("WeaponExcelConfigData.json")]
    internal class WeaponData : ItemData
    {
        [JsonProperty] public readonly WeaponType weaponType;
        [JsonProperty] public readonly uint weaponBaseExp;
        [JsonProperty] public readonly uint[] skillAffix;
        [JsonProperty] public readonly List<WeaponProperty>? weaponProp;
        [JsonProperty] public readonly string awakenTexture;
        [JsonProperty] public readonly string awakenLightMapTexture;
        [JsonProperty] public readonly string awakenIcon;
        [JsonProperty] public readonly uint awakenMaterial;
        [JsonProperty] public readonly uint weaponPromoteId;
        [JsonProperty] public readonly uint storyId;
        [JsonProperty] public readonly uint[] awakenCosts;
        [JsonProperty] public readonly uint gachaCardNameHashPre;
        [JsonProperty] public readonly int weight;
        [JsonProperty] public readonly uint gadgetId;

        public class WeaponProperty
        {
            [JsonProperty] public readonly FightProperty propType;
            [JsonProperty] public readonly float initValue;
            [JsonProperty] public readonly GrowCurveType type;
        }
    }
}
