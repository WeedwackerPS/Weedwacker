using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetPartControlTarget : ConfigAbilityAction
    {
        [JsonProperty] public readonly string[] partRootNames;
        [JsonProperty] public readonly BaseSelectTargetType otherTargets;
    }
}
