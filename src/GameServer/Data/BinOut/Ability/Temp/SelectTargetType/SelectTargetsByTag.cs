using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.SelectTargetType
{
    internal class SelectTargetsByTag : BaseSelectTargetType
    {
        [JsonProperty] public readonly string tag;
    }
}
