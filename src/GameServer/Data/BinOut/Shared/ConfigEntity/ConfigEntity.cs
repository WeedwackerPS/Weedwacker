using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity
{
    internal class ConfigEntity
    {
        [JsonProperty] public readonly ConfigEntityCommon common;
        [JsonProperty] public readonly ConfigHeadControl headControl;
        [JsonProperty] public readonly ConfigEntityPoint specialPoint;
        [JsonProperty] public readonly ConfigCustomAttackShape customAttackShape;
        [JsonProperty] public readonly ConfigModel model;

        public class ConfigEntityPoint
        {
            [JsonProperty] public readonly string elementAbsorb;
            [JsonProperty] public readonly string elementPendant;
            [JsonProperty] public readonly string elementDrop;
            [JsonProperty] public readonly string bulletAim;
            [JsonProperty] public readonly string[] hitPoints;
            [JsonProperty] public readonly string[] selectedPoints;
        }

        public class ConfigModel
        {
            [JsonProperty] public readonly ConfigMatLinearChangedByDistance[] matLinearChangedByDistance;
            [JsonProperty] public readonly string bornEffect;
            [JsonProperty] public readonly string attachEffect;
            [JsonProperty] public readonly bool canBakeMesh;
            [JsonProperty] public readonly bool setPerObjectShadowGroupId;
            [JsonProperty] public readonly bool hasCharacterRendering;
        }

        public class ConfigMatLinearChangedByDistance
        {
            [JsonProperty] public readonly string transformName;
            [JsonProperty] public readonly string[] textureProperty;
            [JsonProperty] public readonly string[] floatProperty;
            [JsonProperty] public readonly float minRatio;
            [JsonProperty] public readonly float maxRatio;
            [JsonProperty] public readonly float minDistance;
            [JsonProperty] public readonly float maxDistance;
        }
    }
}
