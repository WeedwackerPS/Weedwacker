using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class IssueCommand : ConfigAbilityAction
	{
		[JsonProperty] public readonly int commandID;
		[JsonProperty] public readonly float duration;
		[JsonProperty] public readonly BaseSelectTargetType otherTargets;
		[JsonProperty] public readonly BasePredicate[] predicates;
    }
}
