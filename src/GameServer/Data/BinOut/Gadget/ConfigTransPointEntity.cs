using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Gadget
{
    internal class ConfigTransPointEntity : ConfigGadget
    {
        [JsonProperty] public readonly TransPointUpdateMaterial[] updateMaterialList;

        public class TransPointUpdateMaterial
        {
            [JsonProperty] public readonly int level;
            [JsonProperty] public readonly string matPath;
            [JsonProperty] public readonly string[] transforms;
        }
    }
}
