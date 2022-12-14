using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ClearGlobalPos : BaseAction
    {
        [JsonProperty] public readonly string key;
        [JsonProperty] public readonly bool setTarget;
        [JsonProperty] public readonly bool doOffStage;
    }
}
