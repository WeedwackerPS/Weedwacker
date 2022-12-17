using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class TileComplexMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string attackID;
        [JsonProperty] public readonly string attachPointName;
        [JsonProperty] public readonly BaseShape shape;
    }
}
