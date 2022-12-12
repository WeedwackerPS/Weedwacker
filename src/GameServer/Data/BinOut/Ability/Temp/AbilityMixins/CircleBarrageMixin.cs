using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class CircleBarrageMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly int bulletID;
		[JsonProperty] public readonly int innerRadius;
		[JsonProperty] public readonly int cutNum;
		[JsonProperty] public readonly int waveNum;
		[JsonProperty] public readonly float waveCD;
		[JsonProperty] public readonly int wavebulletNum;
		[JsonProperty] public readonly int waveangle;
		[JsonProperty] public readonly float triggerCD;
		[JsonProperty] public readonly string shootPoint;
    }
}
