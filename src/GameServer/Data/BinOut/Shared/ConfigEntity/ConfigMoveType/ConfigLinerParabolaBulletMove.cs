using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigLinerParabolaBulletMove : ConfigLinerBulletMove
    {
        [JsonProperty] public readonly float straightRange;
        [JsonProperty] public readonly float gravityOfAcceleration;
        [JsonProperty] public readonly float airResistance;
    }
}
