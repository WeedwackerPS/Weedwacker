using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetAvatarCanShakeOff : BaseAction
    {
        [JsonProperty] public readonly bool canShakeOff;
    }
}
