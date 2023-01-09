using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType.ConfigBulletMoveAngleType
{
    internal class ConfigBulletMoveAngleRotating : ConfigBulletMoveAngle
    {
        [JsonProperty] public readonly Vector angularVelocity;
    }
}
