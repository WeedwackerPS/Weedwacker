using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetPatternType
{
    internal class ConfigMultiBulletPattern : ConfigBulletPattern
    {
        [JsonProperty] public readonly ConfigMultiBullet multiBulletConfig;
    }

    internal class ConfigMultiBullet
    {
        [JsonProperty] public readonly SelectTargetDefaultType selectTargetDefaultType;
    }

    internal class ConfigEffectItanoCircusBullet : ConfigMultiBullet
    {
        [JsonProperty] public readonly string effectPattern;
    }
}
