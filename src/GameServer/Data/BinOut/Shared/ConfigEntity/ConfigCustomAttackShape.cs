using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity
{
    internal class ConfigCustomAttackShape
    {
        [JsonProperty] public readonly ConfigCustomAttackSphere sphere;
        [JsonProperty] public readonly ConfigCustomAttackBox box;
        [JsonProperty] public readonly ConfigCustomAttackCircle circle;

        public class ConfigCustomAttackSphere
        {
            [JsonProperty] public readonly float customAttackSphereRadius;
        }

        public class ConfigCustomAttackBox
        {
            [JsonProperty] public readonly float customAttackBoxSizeX;
            [JsonProperty] public readonly float customAttackBoxSizeY;
            [JsonProperty] public readonly float customAttackBoxSizeZ;
        }

        public class ConfigCustomAttackCircle
        {
            [JsonProperty] public readonly float customAttackCircleRadius;
            [JsonProperty] public readonly float customAttackCircleInnerRadius;
        }
    }
}
