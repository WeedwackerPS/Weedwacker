using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnableAvatarFlyStateTrail : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool setEnable;
    }
}
