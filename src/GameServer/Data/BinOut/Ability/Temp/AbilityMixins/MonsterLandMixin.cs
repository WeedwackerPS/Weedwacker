using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class MonsterLandMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly string dropToPos;
		[JsonProperty] public readonly int launchSpeedBezierType;
		[JsonProperty] public readonly bool hasDropPos;
		[JsonProperty] public readonly float dropTime;
		[JsonProperty] public readonly float dropSpeed;
		[JsonProperty] public readonly ConfigAbilityAction[] onMotionChange;
	}
}
