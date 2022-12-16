using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ScenePropSyncMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string tileName;
    }
}
