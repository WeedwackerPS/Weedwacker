using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ReplaceFaceAnimationMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string oldFaceAnimations;
        [JsonProperty] public readonly string newFaceAnimations;
    }
}
