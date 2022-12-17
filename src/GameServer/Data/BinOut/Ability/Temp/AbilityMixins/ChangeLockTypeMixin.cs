using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ChangeLockTypeMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly float overrideRange;
        [JsonProperty] public readonly string lockType;
    }
}
