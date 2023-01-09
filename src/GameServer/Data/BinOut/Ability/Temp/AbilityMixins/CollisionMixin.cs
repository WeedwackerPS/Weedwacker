using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class CollisionMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly float minShockSpeed;
		[JsonProperty] public readonly float cd;
		[JsonProperty] public readonly ConfigCollision collision;
		[JsonProperty] public readonly ConfigAbilityAction[] onCollision;
	}
}
