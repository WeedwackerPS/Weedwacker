using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ShowProgressBarAction : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool show;
    }
}
