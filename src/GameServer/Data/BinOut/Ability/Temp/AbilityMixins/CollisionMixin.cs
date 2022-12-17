using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class CollisionMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly float minShockSpeed;
		[JsonProperty] public readonly float cd;
		[JsonProperty] public readonly Collision collision;
		[JsonProperty] public readonly ConfigAbilityAction[] onCollision;

		public class Collision
		{
			[JsonProperty] public readonly string triggerType;
			[JsonProperty] public readonly float triggerCD;
			[JsonProperty] public readonly TargetType targetType;
			[JsonProperty] public readonly bool ignoreScene;
		}
	}
}
