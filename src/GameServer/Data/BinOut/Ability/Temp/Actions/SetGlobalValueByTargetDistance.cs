using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetGlobalValueByTargetDistance : ConfigAbilityAction
	{
		[JsonProperty] public readonly string key;
		[JsonProperty] public readonly BaseSelectTargetType otherTargets;
		[JsonProperty] public readonly BasePredicate[] predicatesForeach;
	}
}
