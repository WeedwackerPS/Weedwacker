using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetGlobalDir : ConfigAbilityAction
    {
        [JsonProperty] public readonly string key;
        [JsonProperty] public readonly BaseBornType born;
    }
}
