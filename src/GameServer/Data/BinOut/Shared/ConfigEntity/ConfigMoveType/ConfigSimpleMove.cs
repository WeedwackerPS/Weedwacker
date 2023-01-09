using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigSimpleMove : ConfigMove
    {
        [JsonProperty] public readonly float ConstSpeedRatio;
        [JsonProperty] public readonly bool followReferenceSystem;
    }
}
