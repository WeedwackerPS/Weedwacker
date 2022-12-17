using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class FireFishingEvent : ConfigAbilityAction
    {
        [JsonProperty] public readonly string eventType;
    }
}
