using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType.ConfigMoveCorrectionType;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigParabolaBulletMove : ConfigBulletMove
    {
        [JsonProperty] public readonly float angleOffHor;
        [JsonProperty] public readonly float gravityOfAcceleration;
        [JsonProperty] public readonly ConfigMoveCorrection correction;
    }
}
