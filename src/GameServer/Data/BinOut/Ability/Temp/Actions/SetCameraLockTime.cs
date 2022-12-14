using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetCameraLockTime : ConfigAbilityAction
    {
        [JsonProperty] public readonly float lockTime;
    }
}
