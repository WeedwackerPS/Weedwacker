using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigMoveType
{
    internal class ConfigRigidbodyMove : ConfigMove
    {
        [JsonProperty] public readonly float constSpeedRatio;
        [JsonProperty] public readonly bool startCloseToGround;
        [JsonProperty] public readonly bool enableCloseToGroundWhenTick;
        [JsonProperty] public readonly bool followReferenceSystem;
    }
}
