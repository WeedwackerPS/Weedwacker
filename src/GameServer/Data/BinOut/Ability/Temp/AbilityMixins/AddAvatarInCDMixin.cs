using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AddAvatarInCDMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly float increasedDuration;
    }
}
