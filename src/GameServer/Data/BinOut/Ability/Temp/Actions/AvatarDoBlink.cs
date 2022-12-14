using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AvatarDoBlink : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool PreferInput;
        [JsonProperty] public readonly float Distance;
    }
}
