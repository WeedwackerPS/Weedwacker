using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ElementReactionShockMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly float thinkInterval;
		[JsonProperty] public readonly ConfigAbilityAction attackAction;
		[JsonProperty] public readonly ConfigAbilityAction conductAction;
}
}
