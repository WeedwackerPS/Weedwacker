using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AvatarExitClimb : BaseAction
    {
        [JsonProperty] public readonly BaseSelectTargetType otherTargets;
    }
}
