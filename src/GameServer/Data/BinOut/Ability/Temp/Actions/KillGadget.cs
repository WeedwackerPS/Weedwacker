using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class KillGadget : ConfigAbilityAction
    {
        [JsonProperty] public readonly BaseSelectTargetType gadgetInfo;
    }
}
