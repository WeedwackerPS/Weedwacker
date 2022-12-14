using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AttachEffectFirework : ConfigAbilityAction
    {
        [JsonProperty] public readonly string effectPattern;
    }
}
