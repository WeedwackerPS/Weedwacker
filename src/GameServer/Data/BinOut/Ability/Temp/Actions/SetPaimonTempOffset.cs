using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetPaimonTempOffset : ConfigAbilityAction
    {
        [JsonProperty] public readonly string from;
        [JsonProperty] public readonly float time;
        [JsonProperty] public readonly Dictionary<string, float> offSetPos;
    }
}
