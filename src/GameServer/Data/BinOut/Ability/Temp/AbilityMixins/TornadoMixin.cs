using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class TornadoMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly int enviroWindStrength;
		[JsonProperty] public readonly int enviroWindRadius;
		[JsonProperty] public readonly TargetType targetType;
		[JsonProperty] public readonly ConfigBornType born;
		[JsonProperty] public readonly BasePredicate[] predicates;
		[JsonProperty] public readonly BaseShape[] stageZone;
	}
}
