using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigEffectAttach
{
    internal class ConfigEffectAttachBox : ConfigEffectAttachShape
    {
        [JsonProperty] public readonly ParticleShapeType emitFrom;
        [JsonProperty] public readonly float scaleX;
        [JsonProperty] public readonly float scaleY;
        [JsonProperty] public readonly float scaleZ;
    }
}
