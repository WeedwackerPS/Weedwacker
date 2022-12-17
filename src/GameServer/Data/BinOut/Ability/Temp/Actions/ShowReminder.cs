using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ShowReminder : ConfigAbilityAction
    {
        [JsonProperty] public readonly int id;
    }
}
