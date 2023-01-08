using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity.ConfigEffectAttach
{
    internal class ConfigEffectAttachSkinnedMesh : ConfigEffectAttachShape
    {
        [JsonProperty] public readonly string mesh;
    }
}
