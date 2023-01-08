using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigBulletMoveAngleType
{
    internal class ConfigBulletMoveAngleRotating : ConfigBulletMoveAngle
    {
        [JsonProperty] public readonly Vector angularVelocity;
    }
}
