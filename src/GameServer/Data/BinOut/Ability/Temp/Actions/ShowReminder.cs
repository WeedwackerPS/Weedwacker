using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ShowReminder : BaseAction
    {
        [JsonProperty] public readonly int id;
    }
}
