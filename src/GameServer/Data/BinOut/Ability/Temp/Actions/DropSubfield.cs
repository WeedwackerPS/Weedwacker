using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class DropSubfield : ConfigAbilityAction
    {
        [JsonProperty] public readonly string subfieldName;
    }
}
