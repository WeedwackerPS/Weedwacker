using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnableGadgetIntee : BaseAction
    {
        [JsonProperty] public readonly bool enable;
    }
}
