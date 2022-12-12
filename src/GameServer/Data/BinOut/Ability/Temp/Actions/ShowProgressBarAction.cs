using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ShowProgressBarAction : BaseAction
    {
        [JsonProperty] public readonly bool show;
    }
}
