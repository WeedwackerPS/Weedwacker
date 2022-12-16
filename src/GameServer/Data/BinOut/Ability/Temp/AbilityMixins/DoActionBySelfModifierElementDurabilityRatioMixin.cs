using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DoActionBySelfModifierElementDurabilityRatioMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly float[] valueSteps;
		[JsonProperty] public readonly ConfigAbilityAction[] actionQueues;
    }
}
