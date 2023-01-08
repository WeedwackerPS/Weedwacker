using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType.ConfigBulletMoveAngleType
{
    internal class ConfigBulletMoveAngleByVelocity : ConfigBulletMoveAngle
    {
        [JsonProperty] public readonly float traceLerpCoef;
        [JsonProperty] public readonly bool isSmoothRotation;
    }
}
