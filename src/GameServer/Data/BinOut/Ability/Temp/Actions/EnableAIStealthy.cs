using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnableAIStealthy : BaseAction
    {
        [JsonProperty] public readonly bool enable;
    }
}
