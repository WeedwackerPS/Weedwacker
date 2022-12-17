using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class CreateGadget : ConfigAbilityAction
    {
        [JsonProperty] public readonly BaseBornType born;
        [JsonProperty] public readonly int gadgetID;
        [JsonProperty] public readonly TargetType campTargetType;
    }
}
