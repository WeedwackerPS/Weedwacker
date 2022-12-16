using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ForceAirStateFly : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool isActive;
    }
}
