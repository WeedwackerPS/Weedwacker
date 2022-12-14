using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class BillboardFixedMarkMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string prefabName;
    }
}
