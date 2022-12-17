using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetCrashDamage : ConfigAbilityAction
	{
		[JsonProperty] public readonly float maxVelocity;
		[JsonProperty] public readonly float minDamage;
		[JsonProperty] public readonly float maxDamage;
		[JsonProperty] public readonly string key;
		[JsonProperty] public readonly BasePredicate[] predicates;
	}
}
