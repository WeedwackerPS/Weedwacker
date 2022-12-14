using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class GetInteractIdToGlobalValue : BaseAction
    {
        [JsonProperty] public readonly string key;
    }
}
