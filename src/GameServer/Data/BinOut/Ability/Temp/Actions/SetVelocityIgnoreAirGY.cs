using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetVelocityIgnoreAirGY : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool? ignoreAirGY;
        [JsonProperty] public readonly bool? doOffStage;
    }
}
