using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class TileAttackMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string attackID;
    }
}
