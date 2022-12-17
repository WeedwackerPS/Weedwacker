using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class KillServerGadget : ConfigAbilityAction
	{
		[JsonProperty] public readonly BaseSelectTargetType gadgetInfo;
    }
}
