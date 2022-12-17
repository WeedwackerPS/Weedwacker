using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ClearGlobalPos : ConfigAbilityAction
    {
        [JsonProperty] public readonly string key;
        [JsonProperty] public readonly bool setTarget;
        [JsonProperty] public readonly bool doOffStage;
    }
}
