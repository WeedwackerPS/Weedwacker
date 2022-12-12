using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachModifierToTargetDistanceMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly int[] targetIDs;
		[JsonProperty] public readonly bool byserver;
		[JsonProperty] public readonly object[] valueSteps;
		[JsonProperty] public readonly string[] modifierNameSteps;
		[JsonProperty] public readonly string BlendParam;
		[JsonProperty] public readonly string effectPattern;
		[JsonProperty] public readonly int[] BlendDistance;
    }
}
