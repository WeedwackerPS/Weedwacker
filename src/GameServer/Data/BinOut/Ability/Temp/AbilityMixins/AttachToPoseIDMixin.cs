using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachToPoseIDMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int[] poseIDs;
        [JsonProperty] public readonly string modifierName;
    }
}
