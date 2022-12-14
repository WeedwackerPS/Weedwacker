using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetAvatarCanShakeOff : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool canShakeOff;
    }
}
