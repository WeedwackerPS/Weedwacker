using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class BoxClampWindZoneMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly Dictionary<string, float> size;
		[JsonProperty] public readonly ConfigBornType born;
		[JsonProperty] public readonly float attracForceStrength;
		[JsonProperty] public readonly float maxStrengthRange;
    }
}
