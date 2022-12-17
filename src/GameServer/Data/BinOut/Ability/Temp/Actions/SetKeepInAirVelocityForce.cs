using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetKeepInAirVelocityForce : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool setEnable;
    }
}
