using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType.ConfigMoveCorrectionType
{
    internal class ConfigParabolaBulletMoveCorrection : ConfigMoveCorrection
    {
        [JsonProperty] public readonly float deviation;
        [JsonProperty] public readonly float fixAngleOfVer;
        [JsonProperty] public readonly float minSpeed;
        [JsonProperty] public readonly float maxSpeed;
    }
}
