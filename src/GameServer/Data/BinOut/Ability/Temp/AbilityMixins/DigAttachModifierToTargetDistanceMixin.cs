using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class DigAttachModifierToTargetDistanceMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly int targetID;
		[JsonProperty] public readonly float distance;
		[JsonProperty] public readonly ConfigAbilityAction[] foundActionArray;
		[JsonProperty] public readonly ConfigAbilityAction[] unfoundActionArray;
    }
}
