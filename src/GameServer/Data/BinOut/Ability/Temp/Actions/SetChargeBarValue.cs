using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetChargeBarValue : BaseAction
    {
        [JsonProperty] public readonly float value;
    }
}
