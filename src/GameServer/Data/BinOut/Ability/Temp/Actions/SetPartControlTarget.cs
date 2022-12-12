using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetPartControlTarget : BaseAction
    {
        [JsonProperty] public readonly string[] partRootNames;
        [JsonProperty] public readonly BaseSelectTargetType otherTargets;
    }
}
