using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class StartDither : ConfigAbilityAction
    {
        [JsonProperty] public readonly float duration;
    }
}
