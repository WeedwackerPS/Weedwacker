using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetAIHitFeeling : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool enable;
    }
}
