using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AvatarStrafeFuelMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly float initFuel;
        [JsonProperty] public readonly float costSpeed;
        [JsonProperty] public readonly RemoveUniqueModifier[] onEmptied;
    }
}
