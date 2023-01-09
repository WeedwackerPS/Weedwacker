using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigEffectAttach
{
    internal class ConfigEffectAttachMesh : ConfigEffectAttachShape
    {
        [JsonProperty] public readonly string mesh;
    }
}
