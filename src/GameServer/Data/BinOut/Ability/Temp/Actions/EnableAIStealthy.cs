using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnableAIStealthy : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool enable;
    }
}
