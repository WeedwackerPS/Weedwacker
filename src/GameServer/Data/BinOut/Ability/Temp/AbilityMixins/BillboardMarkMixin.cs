using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class BillboardMarkMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string iconName;
    }
}
