using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class BoxClampWindZoneMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly Dictionary<string, float> size;
		[JsonProperty] public readonly BaseBornType born;
		[JsonProperty] public readonly float attracForceStrength;
		[JsonProperty] public readonly float maxStrengthRange;
    }
}
