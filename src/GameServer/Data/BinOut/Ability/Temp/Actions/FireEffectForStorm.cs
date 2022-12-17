using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class FireEffectForStorm : ConfigAbilityAction
    {
        [JsonProperty] public readonly float height;
        [JsonProperty] public readonly BaseBornType born;
    }
}
