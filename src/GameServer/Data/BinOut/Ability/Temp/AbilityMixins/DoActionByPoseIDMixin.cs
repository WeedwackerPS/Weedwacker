using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoActionByPoseIDMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int[] poseIDs;
        [JsonProperty] public readonly ConfigAbilityAction[] enterActions;
    }
}
