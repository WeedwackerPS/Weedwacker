using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnableGadgetSpecialCamera : BaseAction
    {
        [JsonProperty] public readonly bool enable;
    }
}
