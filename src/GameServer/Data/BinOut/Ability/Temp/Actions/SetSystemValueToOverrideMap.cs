using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetSystemValueToOverrideMap : BaseAction
    {
        [JsonProperty] public readonly string key;
        [JsonProperty] public readonly string type;
    }
}
